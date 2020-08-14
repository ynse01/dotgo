
namespace dotgo.os
{
    public struct SyscallError
    {
        public string Syscall;
        public error err;

        public string Error()
        {
            return err.Error();
        }

        public bool Timeout()
        {
            return false;
        }

        public error Unwrap()
        {
            return err;
        }
    }
}
