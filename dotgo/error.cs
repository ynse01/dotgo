
namespace dotgo
{
    public struct error
    {
        private string err;

        public error(string err)
        {
            this.err = err;
        }

        public string Error()
        {
            return err;
        }
    }
}
