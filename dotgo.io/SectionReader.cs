
namespace dotgo.io
{
    /// <summary>
    /// SectionReader implements Read, Seek, and ReadAt on a section of an underlying ReaderAt. 
    /// </summary>
    public struct SectionReader
    {
        private static error errWhence = errors.New("Seek: invalid whence");
        private static error errOffset = errors.New("Seek: invalid offset");

        private ReaderAt reader;
        private long bas;
        private long off;
        private long limit;

        public SectionReader(ReaderAt r, long off, long n)
        {
            reader = r;
            this.off = off;
            bas = off;
            limit = off + n;
        }

        public ReaderReadReturn Read(byte[] p)
        {
            if (off >= limit)
            {
                return new ReaderReadReturn() { n = 0, err = io.EOF };
            }
            var max = limit - off;
            if (dotgo.len(p) > max)
            {
                //p = new slice<byte>(p, 0, (int)max);
            }
            var readResult = reader.ReadAt(p, off);
            off += readResult.n;
            return readResult;
        }

        public ReaderReadReturn ReadAt(byte[] p, long off)
        {
            if (off < 0 || off >= limit - bas)
            {
                return new ReaderReadReturn() { n = 0, err = io.EOF };
            }
            off += bas;
            var max = limit - off;
            if (dotgo.len(p) > max)
            {
                //p = new slice<byte>(p, 0, (int)max);
                var readResult = reader.ReadAt(p, off);
                var err = readResult.err;
                if (readResult.err == error.Nil)
                {
                    err = io.EOF;
                }
                return new ReaderReadReturn() { n = readResult.n, err = err };
            }
            return reader.ReadAt(p, off);
        }

        public SeekerSeekReturn Seek(long offset, int whense)
        {
            var retVal = SeekerSeekReturn.Nil;
            switch(whense)
            {
                default:
                    return new SeekerSeekReturn() { n = 0, err = errWhence };
                case io.SeekStart:
                    offset += this.bas;
                    break;
                case io.SeekCurrent:
                    offset += this.off;
                    break;
                case io.SeekEnd:
                    offset += this.limit;
                    break;
            }
            if (offset < this.bas)
            {
                return new SeekerSeekReturn() { n = 0, err = errOffset };
            }
            off = offset;
            return retVal;
        }

        /// <summary>
        /// Size returns the size of the section in bytes. 
        /// </summary>
        public long Size()
        {
            return limit - bas;
        }
    }
}
