
namespace dotgo.io
{
    public class LimitedReader : Reader
    {
        public Reader R;
        public long N;

        public LimitedReader(Reader r, long n)
        {
            R = r;
            N = n;
        }

        public ReaderReadReturn Read(byte[] p)
        {
            return R.Read(p);
        }
    }
}
