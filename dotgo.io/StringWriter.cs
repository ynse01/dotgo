
namespace dotgo.io
{
    /// <summary>
    /// StringWriter is the interface that wraps the WriteString method. 
    /// </summary>
    public interface StringWriter
    {
        WriterWriteReturn WriteString(string s);
    }
}
