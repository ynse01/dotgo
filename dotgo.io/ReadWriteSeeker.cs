
namespace dotgo.io
{
    /// <summary>
    /// ReadWriteSeeker is the interface that groups the basic Read, Write and Seek methods. 
    /// </summary>
    public interface ReadWriteSeeker : Reader, Writer, Seeker
    {
    }
}
