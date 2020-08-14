
namespace dotgo.io
{
    /// <summary>
    /// ReadCloser is the interface that groups the basic Read and Close methods. 
    /// </summary>
    public interface ReadCloser : Reader, Closer
    {
    }
}
