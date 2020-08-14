
namespace dotgo.io
{
    /// <summary>
    ///  ReaderFrom is the interface that wraps the ReadFrom method.
    ///  ReadFrom reads data from r until EOF or error.The return value n is the number of bytes read.
    ///  Any error except io.EOF encountered during the read is also returned.
    ///  The Copy function uses ReaderFrom if available.
    /// </summary>
    public interface ReaderFrom
    {
        (int n, error err) ReadFrom(Reader r);
    }
}
