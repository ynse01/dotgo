
namespace dotgo.io
{
    public interface WriterAt
    {
        WriterWriteReturn WriteAt(byte[] p, long off);
    }
}
