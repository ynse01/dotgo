
namespace dotgo.os
{
    public struct Process
    {
        public int Pid;

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

        public struct WaitReturn
        {
            public ProcessState state;
            public error err;
        }

        public WaitReturn Wait()
        {
            return new WaitReturn();
        }
    }
}
