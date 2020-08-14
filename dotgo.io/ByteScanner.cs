
namespace dotgo.io
{
    public interface ByteScanner : ByteReader
    {
        error UnreadByte();
    }
}
