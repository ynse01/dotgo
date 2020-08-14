
namespace dotgo.io
{
    public class SectionReader
    {
        private ReaderAt reader;
        private long offset;
        private long size;

        public SectionReader(ReaderAt r, long off, long n)
        {
            reader = r;
            offset = off;
            size = n;
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
            return new SeekerSeekReturn();
        }

        public long Size()
        {
            return size;
        }
    }
}
