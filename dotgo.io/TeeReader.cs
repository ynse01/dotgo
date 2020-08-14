
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

        public ReaderReadReturn Read(byte[] p)
        {
            var readResult = r.Read(p);
            if (readResult.n > 0)
            {
                var writeResult = w.Write(p);
                if (writeResult.err != error.Nil)
                {
                    return new ReaderReadReturn() { n = readResult.n, err = writeResult.err };
                }
            }
            return ReaderReadReturn.Nil;
        }
    }
}
