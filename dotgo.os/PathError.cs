
namespace dotgo.os
{
    public struct PathError
    {
        public string Op;
        public string Path;
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
