
namespace dotgo.io
{
    /// <summary>
    ///  ByteScanner is the interface that adds the UnreadByte method to the basic ReadByte method.
    ///  UnreadByte causes the next call to ReadByte to return the same byte as the previous call to ReadByte.
    ///  It may be an error to call UnreadByte twice without an intervening call to ReadByte.
    /// </summary>
    public interface ByteScanner : ByteReader
    {
        error UnreadByte();
    }
}
