
namespace dotgo.os
{
    public struct Process
    {
        public int Pid;

        public static Process Nil = new Process();

        public error Kill()
        {
            return default(error);
        }

        public error Release()
        {
            return default(error);
        }

        public error Signal(Signal sig)
        {
            return default(error);
        }

        public (ProcessState state, error err) Wait()
        {
            return (ProcessState.Nil, error.Nil);
        }
    }
}
