
namespace dotgo.io
{
    /// <summary>
    ///  ByteReader is the interface that wraps the ReadByte method.
    ///  ReadByte reads and returns the next byte from the input or any error encountered.
    ///  If ReadByte returns an error, no input byte was consumed, and the returned byte value is undefined.
    ///  ReadByte provides an efficient interface for byte-at-time processing.A Reader that does not implement
    ///  ByteReader can be wrapped using bufio.NewReader to add this method.
    /// </summary>
    public interface ByteReader
    {
        (byte b, error err) ReadByte();
    }
}
