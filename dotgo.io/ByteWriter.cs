
namespace dotgo.io
{
    /// <summary>
    /// ByteWriter is the interface that wraps the WriteByte method.
    /// </summary>
    public interface ByteWriter
    {
        error WriteByte(byte c);
    }
}
