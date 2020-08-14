
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
        private long offset;
        private long size;
        private long pos;

        public SectionReader(ReaderAt r, long off, long n)
        {
            reader = r;
            offset = off;
            size = n;
            pos = offset;
        }

        public ReaderReadReturn Read(byte[] p)
        {
            return reader.ReadAt(p, offset);
        }

        public ReaderReadReturn ReadAt(byte[] p, long off)
        {
            return reader.ReadAt(p, offset + off);
        }

        public SeekerSeekReturn Seek(long offset, int whense)
        {
            var retVal = SeekerSeekReturn.Nil;
            switch(whense)
            {
                default:
                    return new SeekerSeekReturn() { n = 0, err = errWhence };
                case io.SeekStart:
                    offset += this.offset;
                    break;
                case io.SeekCurrent:
                    offset += this.pos;
                    break;
                case io.SeekEnd:
                    offset += this.offset + this.size;
                    break;
            }
            if (offset < this.offset)
            {
                return new SeekerSeekReturn() { n = 0, err = errOffset };
            }
            pos = offset;
            return retVal;
        }

        /// <summary>
        /// Size returns the size of the section in bytes. 
        /// </summary>
        public long Size()
        {
            return size;
        }
    }
}
