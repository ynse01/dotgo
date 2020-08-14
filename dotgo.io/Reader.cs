
namespace dotgo.io
{
    public struct ReaderReadReturn
    {
        int n;
        error err;
    }

    public interface Reader
    {
        ReaderReadReturn Read(byte[] p);
    }
}
