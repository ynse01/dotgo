
namespace dotgo.io
{
    public struct SeekerSeekReturn
    {
        public long n;
        public error err;

        public static SeekerSeekReturn Nil = new SeekerSeekReturn() { n = 0, err = error.Nil };
    }

    /// <summary>
    ///  Seeker is the interface that wraps the basic Seek method.
    ///  Seek sets the offset for the next Read or Write to offset, interpreted according to whence:
    ///  SeekStart means relative to the start of the file, SeekCurrent means relative to the current offset, and
    ///  SeekEnd means relative to the end.Seek returns the new offset relative to the start of the file and an error, if any.
    ///  Seeking to an offset before the start of the file is an error.Seeking to any positive offset is legal,
    ///  but the behavior of subsequent I/O operations on the underlying object is implementation-dependent.
    /// </summary>
    public interface Seeker
    {
        SeekerSeekReturn Seek(long offset, int whence);
    }
}
