
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

        public (int n, error err) Read(byte[] p)
        {
            var l = this;
            if (l.N <= 0)
            {
                return (0, io.EOF );
            }
            if (globals.len(p) > l.N)
            {
                //p = new slice<byte>(p, 0, (int)N);
            }
            (int n, error err) = l.R.Read(p);
            N = n;
            return ( (int)N, error.Nil);
        }
    }
}
