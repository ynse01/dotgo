
namespace dotgo.io
{
    /// <summary>
    /// A LimitedReader reads from R but limits the amount of data returned to just N bytes.
    /// Each call to Read updates N to reflect the new amount remaining.
    /// Read returns EOF when N <= 0 or when the underlying R returns EOF. 
    /// </summary>
    public struct LimitedReader : Reader
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
            if (N <= 0)
            {
                return new ReaderReadReturn() { n = 0, err = io.EOF };
            }
            if (dotgo.len(p) > N)
            {
                //p = new slice<byte>(p, 0, (int)N);
            }
            var readResult = R.Read(p);
            N = readResult.n;
            return new ReaderReadReturn() { n = (int)N, err = error.Nil };
        }
    }
}
