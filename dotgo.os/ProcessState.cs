
namespace dotgo.os
{
    public struct ProcessState
    {
        private int pid;

        internal ProcessState(int pid)
        {
            this.pid = pid;
        }

        public int ExitCode()
        {
            return 0;
        }

        public bool Exited()
        {
            return false;
        }

        public int Pid()
        {
            return pid;
        }

        public string String()
        {
            return ToString();
        }

        public bool Success()
        {
            return ExitCode() == 0;
        }

        public Duration SystemTime()
        {
            return default(Duration);
        }

        public Duration UserTime()
        {
            return default(Duration);
        }
    }
}
