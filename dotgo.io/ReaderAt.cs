
namespace dotgo.io
{
    public interface ReaderAt
    {
        ReaderReadReturn ReadAt(byte[] p, long offset);
    }
}
