
namespace dotgo.io
{
    /// <summary>
    /// ReadWriteCloser is the interface that groups the basic Read, Write and Close methods. 
    /// </summary>
    public interface ReadWriteCloser : Reader, Writer, Closer
    {
    }
}
