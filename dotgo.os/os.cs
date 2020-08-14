
using IO = System.IO;
using System.Runtime.InteropServices;
using System;
using System.Reflection;

namespace dotgo.os
{
    public static class os
    {
        public static int O_RDONLY = (int)IO.FileAccess.Read;
        public static int O_WRONLY = (int)IO.FileAccess.Write;
        public static int O_RDWR = (int)IO.FileAccess.ReadWrite;
        public static int O_APPEND = 4;
        public static int O_CREATE = 8;
        public static int O_EXCL = 16;
        public static int O_SYNC = 32;
        public static int O_TRUNC = 64;

        public static int SEEK_SET = 0;
        public static int SEEK_CUR = 1;
        public static int SEEK_END = 2;

        public static string DevNull = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "NUL" : "/dev/null";

        public static string PathSeperator = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "\\" : "/";
        public static string PathListSeperator = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? ";" : ":";

        public static error ErrInvalid = errors.New("invalid argument");
        public static error ErrPermission = errors.New("permission denied");
        public static error ErrExist = errors.New("file already exists");
        public static error ErrNotExist = errors.New("file does not exist");
        public static error ErrClosed = errors.New("file already closed");
        public static error ErrNoDeadline = errors.New("file type does not support deadline");
        public static error ErrDeadlineExceeded = errors.New("i/o timeout");

        public static File Stdin;
        public static File Stdout;
        public static File Stderr;

        public static slice<string> Args;

        public static Signal Interrupt;
        public static Signal Kill;

        public static error Chdir(string dir)
        {
            return default(error);
        }

        public static (Process p, error err) FindProcess(int pid)
        {
            return (Process.Nil, error.Nil);
        }

        public static (Process p, error err) StartProcess(string name, string[] argv, ProcAttr attr)
        {
            return (Process.Nil, error.Nil);
        }

        public static int Run<T>(string[] args)
        {
            Args = new slice<string>(args, 0, args.Length);
            var ass = typeof(T).Assembly;
            foreach (Type t in ass.GetTypes())
            {
                if (t.GetCustomAttribute<MainModuleAttribute>() != null)
                {
                    // Found our main module type
                    break;
                }
            }
            return 0;
        }

    }
}
