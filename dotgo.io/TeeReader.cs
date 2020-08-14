
namespace dotgo.io
{
    public class TeeReader : Reader
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
            throw new System.NotImplementedException();
        }
    }
}
