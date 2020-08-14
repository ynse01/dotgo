
namespace dotgo.io
{
    public class PipeWriter : Writer
    {
        public WriterWriteReturn Write(byte[] p)
        {
            return new WriterWriteReturn();
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
