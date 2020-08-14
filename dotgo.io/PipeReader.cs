
namespace dotgo.io
{
    public class PipeReader : Reader
    {
        public ReaderReadReturn Read(byte[] p)
        {
            return new ReaderReadReturn();
        }

        public error Close()
        {
            return Close(io.ErrClosedPipe);
        }

        public error Close(error err)
        {
            return default(error);
        }
    }
}
