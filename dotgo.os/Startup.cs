using System;
using System.Reflection;

namespace dotgo.os
{
    public static class Startup
    {
        public static int Run(string[] args)
        {
            // Expose command line arguments
            os.Args = new slice<string>(args, 0, args.Length);
            // TODO: Connect standard in, out and error
            // Find main entry method
            var ass = Assembly.GetEntryAssembly();
            foreach (Type t in ass.GetTypes())
            {
                if (t.GetCustomAttribute<MainModuleAttribute>() != null)
                {
                    // Found our main module type
                    var mainMethod = t.GetMethod("main");
                    if (mainMethod != null)
                    {
                        var retVal = mainMethod.Invoke(null, null);
                        if (retVal == null)
                        {
                            return 0;
                        }
                        return (int)retVal;
                    }
                    break;
                }
            }
            return -1;
        }

    }
}
