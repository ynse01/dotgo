
namespace dotgo.io
{
    /// <summary>
    /// StringWriter is the interface that wraps the WriteString method. 
    /// </summary>
    public interface StringWriter
    {
        (int n, error err) WriteString(string s);
    }
}
