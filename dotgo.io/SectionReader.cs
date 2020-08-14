
namespace dotgo.io
{
    /// <summary>
    /// SectionReader implements Read, Seek, and ReadAt on a section of an underlying ReaderAt. 
    /// </summary>
    public struct SectionReader
    {
        private static error errWhence = errors.New("Seek: invalid whence");
        private static error errOffset = errors.New("Seek: invalid offset");

        private ReaderAt r;
        private long bas;
        private long off;
        private long limit;

        internal SectionReader(ReaderAt r, long off, long bas, long limit)
        {
            this.r = r;
            this.off = off;
            this.bas = off;
            this.limit = limit;
        }

        public (int n, error err) Read(byte[] p)
        {
            var s = this;
            if (s.off >= s.limit)
            {
                return ( 0, io.EOF );
            }
            var max = s.limit - s.off;
            if (this.len(p) > max)
            {
                //p = new slice<byte>(p, 0, (int)max);
            }
            (int n , error err) = s.r.ReadAt(p, off);
            s.off += n;
            return (n, err);
        }

        public (int n, error err) ReadAt(byte[] p, long off)
        {
            var s = this;
            if (off < 0 || off >= s.limit - s.bas)
            {
                return (0, io.EOF);
            }
            off += s.bas;
            var max = s.limit - off;
            if (this.len(p) > max)
            {
                //p = new slice<byte>(p, 0, (int)max);
                (int n, error err) = s.r.ReadAt(p, off);
                if (err == error.Nil)
                {
                    err = io.EOF;
                }
                return (n, err);
            }
            return s.r.ReadAt(p, off);
        }

        public (int n, error err) Seek(long offset, int whense)
        {
            var s = this;
            switch(whense)
            {
                default:
                    return (0, errWhence);
                case io.SeekStart:
                    offset += s.bas;
                    break;
                case io.SeekCurrent:
                    offset += s.off;
                    break;
                case io.SeekEnd:
                    offset += s.limit;
                    break;
            }
            if (offset < s.bas)
            {
                return (0, errOffset);
            }
            s.off = offset;
            return ((int)(offset - s.bas), error.Nil);
        }

        /// <summary>
        /// Size returns the size of the section in bytes. 
        /// </summary>
        public long Size()
        {
            var s = this;
            return s.limit - s.bas;
        }
    }
}
