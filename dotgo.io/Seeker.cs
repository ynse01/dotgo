
namespace dotgo.io
{
    public struct SeekerSeekReturn
    {
        long n;
        error err;
    }
    public interface Seeker
    {
        SeekerSeekReturn Seek(long offset, int whence);
    }
}
