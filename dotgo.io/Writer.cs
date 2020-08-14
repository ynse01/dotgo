
namespace dotgo.io
{
    public struct WriterWriteReturn
    {
        int n;
        error err;
    }

    public interface Writer
    {
        WriterWriteReturn Write(byte[] p);
    }
}
