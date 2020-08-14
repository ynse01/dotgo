
namespace dotgo.os
{
    public struct LinkError
    {
        public string Op;
        public string Old;
        public string New;
        public error err;

        public string Error()
        {
            return err.Error();
        }

        public error Unwrap()
        {
            return err;
        }
    }
}
