
namespace dotgo.io
{
    public struct ByteReaderReadByteReturn
    {
        byte b;
        error err;
    }

    public interface ByteReader
    {
        ByteReaderReadByteReturn ReadByte();
    }
}
