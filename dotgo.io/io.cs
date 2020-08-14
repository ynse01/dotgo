using System;

namespace dotgo.io
{
    public class io
    {
        public static error EOF = errors.New("EOF");

        public static error ErrClosedPipe = errors.New("io: read/write on closed pipe");

        public static error ErrNoProgress = errors.New("multiple Read calls return no data or error");

        public static error ErrShortBuffer = errors.New("short buffer");

        public static error ErrShortWrite = errors.New("short write");

        public static error ErrUnexpectedEOF = errors.New("unexpected EOF");

        public struct CopyBufferReturn
        {
            long written;
            error err;
        }

        public static CopyBufferReturn CopyBuffer(Writer dst, Reader src, byte[] buf)
        {
            return new CopyBufferReturn();
        }

        public static CopyBufferReturn CopyN(Writer dst, Reader src, long n)
        {
            return new CopyBufferReturn();
        }

        public static void Pipe(PipeReader reader, PipeWriter writer)
        {

        }

        public static ReaderReadReturn ReadAtLeast(Reader r, byte[] buf, int min)
        {
            return new ReaderReadReturn();
        }

        public static ReaderReadReturn ReadFull(Reader r, byte[] buf)
        {
            return new ReaderReadReturn();
        }

        public static WriterWriteReturn WriteString(Writer w, string s)
        {
            return new WriterWriteReturn();
        }
    }
}
