
namespace dotgo.io
{
    public struct TeeReader : Reader
    {
        private Reader r;
        private Writer w;

        public TeeReader(Reader r, Writer w)
        {
            this.r = r;
            this.w = w;
        }

        public (int n, error err) Read(byte[] p)
        {
            (int n, error err) = r.Read(p);
            if (n > 0)
            {
                (int wn, error werr) = w.Write(p);
                if (werr != error.Nil)
                {
                    return (wn, werr);
                }
            }
            return (n, err);
        }
    }
}
