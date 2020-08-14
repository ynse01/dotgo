
namespace dotgo.io
{
    /// <summary>
    /// Package io provides basic interfaces to I/O primitives. Its primary job is to wrap existing implementations
    /// of such primitives, such as those in package os, into shared public interfaces that abstract the functionality,
    /// plus some other related primitives.
    /// Because these interfaces and primitives wrap lower-level operations with various implementations,
    /// unless otherwise informed clients should not assume they are safe for parallel execution.
    /// </summary>
    public static class io
    {
        /// <summary>
        /// seek relative to the origin of the file
        /// </summary>
        public const int SeekStart = 0;
        
        /// <summary>
        /// seek relative to the current offset
        /// </summary>
        public const int SeekCurrent = 1;

        /// <summary>
        /// seek relative to the end
        /// </summary>
        public const int SeekEnd = 2;

        /// <summary>
        /// EOF is the error returned by Read when no more input is available. Functions should return EOF only to signal
        /// a graceful end of input. If the EOF occurs unexpectedly in a structured data stream, the appropriate error
        /// is either ErrUnexpectedEOF or some other error giving more detail. 
        /// </summary>
        public static error EOF = errors.New("EOF");

        /// <summary>
        /// ErrClosedPipe is the error used for read or write operations on a closed pipe. 
        /// </summary>
        public static error ErrClosedPipe = errors.New("io: read/write on closed pipe");

        /// <summary>
        /// ErrNoProgress is returned by some clients of an io.Reader when many calls to Read have failed to return
        /// any data or error, usually the sign of a broken io.Reader implementation. 
        /// </summary>
        public static error ErrNoProgress = errors.New("multiple Read calls return no data or error");

        /// <summary>
        /// ErrShortBuffer means that a read required a longer buffer than was provided. 
        /// </summary>
        public static error ErrShortBuffer = errors.New("short buffer");

        /// <summary>
        /// ErrShortWrite means that a write accepted fewer bytes than requested but failed to return an explicit error. 
        /// </summary>
        public static error ErrShortWrite = errors.New("short write");

        /// <summary>
        /// ErrUnexpectedEOF means that EOF was encountered in the middle of reading a fixed-size block or data structure. 
        /// </summary>
        public static error ErrUnexpectedEOF = errors.New("unexpected EOF");

        public struct ioCopyReturn
        {
            public long written;
            public error err;

            public static ioCopyReturn Nil = new ioCopyReturn() { written = 0, err = error.Nil };
        }

        /// <summary>
        /// Copy copies from src to dst until either EOF is reached on src or an error occurs.
        /// It returns the number of bytes copied and the first error encountered while copying, if any.
        /// A successful Copy returns err == nil, not err == EOF.Because Copy is defined to read from src until EOF,
        /// it does not treat an EOF from Read as an error to be reported.
        /// If src implements the WriterTo interface, the copy is implemented by calling src.WriteTo(dst). 
        /// Otherwise, if dst implements the ReaderFrom interface, the copy is implemented by calling dst.ReadFrom(src). 
        /// </summary>
        public static ioCopyReturn Copy(Writer dst, Reader src)
        {
            return new ioCopyReturn();
        }

        /// <summary>
        /// CopyBuffer is identical to Copy except that it stages through the provided buffer (if one is required)
        /// rather than allocating a temporary one. If buf is nil, one is allocated; otherwise if it has zero length,
        /// CopyBuffer panics.
        /// If either src implements WriterTo or dst implements ReaderFrom, buf will not be used to perform the copy.
        /// </summary>
        public static ioCopyReturn CopyBuffer(Writer dst, Reader src, byte[] buf)
        {
            return new ioCopyReturn();
        }

        /// <summary>
        /// CopyN copies n bytes (or until an error) from src to dst. It returns the number of bytes copied and
        /// the earliest error encountered while copying. On return, written == n if and only if err == nil.
        /// If dst implements the ReaderFrom interface, the copy is implemented using it. 
        /// </summary>
        public static ioCopyReturn CopyN(Writer dst, Reader src, long n)
        {
            return new ioCopyReturn();
        }

        /// <summary>
        ///  Pipe creates a synchronous in-memory pipe. It can be used to connect code expecting an io.Reader
        ///  with code expecting an io.Writer.
        ///  Reads and Writes on the pipe are matched one to one except when multiple Reads are needed to consume
        ///  a single Write.That is, each Write to the PipeWriter blocks until it has satisfied one or more Reads
        ///  from the PipeReader that fully consume the written data.The data is copied directly from the Write
        ///  to the corresponding Read (or Reads); there is no internal buffering.
        ///  It is safe to call Read and Write in parallel with each other or with Close.Parallel calls to Read and
        ///  parallel calls to Write are also safe: the individual calls will be gated sequentially.
        /// </summary>
        public static void Pipe(ptr<PipeReader> reader, ptr<PipeWriter> writer)
        {

        }

        /// <summary>
        /// ReadAtLeast reads from r into buf until it has read at least min bytes.
        /// It returns the number of bytes copied and an error if fewer bytes were read.
        /// The error is EOF only if no bytes were read. If an EOF happens after reading fewer than min bytes,
        /// ReadAtLeast returns ErrUnexpectedEOF. If min is greater than the length of buf,
        /// ReadAtLeast returns ErrShortBuffer. On return, n >= min if and only if err == nil.
        /// If r returns an error having read at least min bytes, the error is dropped. 
        /// </summary>
        public static ReaderReadReturn ReadAtLeast(Reader r, byte[] buf, int min)
        {
            return new ReaderReadReturn();
        }

        /// <summary>
        /// ReadFull reads exactly len(buf) bytes from r into buf. It returns the number of bytes copied and
        /// an error if fewer bytes were read. The error is EOF only if no bytes were read.
        /// If an EOF happens after reading some but not all the bytes, ReadFull returns ErrUnexpectedEOF.
        /// On return, n == len(buf) if and only if err == nil. If r returns an error having read at least
        /// len(buf) bytes, the error is dropped. 
        /// </summary>
        public static ReaderReadReturn ReadFull(Reader r, byte[] buf)
        {
            return new ReaderReadReturn();
        }

        /// <summary>
        /// WriteString writes the contents of the string s to w, which accepts a slice of bytes.
        /// If w implements StringWriter, its WriteString method is invoked directly.
        /// Otherwise, w.Write is called exactly once. 
        /// </summary>
        public static WriterWriteReturn WriteString(Writer w, string s)
        {
            return new WriterWriteReturn();
        }

        /// <summary>
        /// LimitReader returns a Reader that reads from r but stops with EOF after n bytes.
        /// The underlying implementation is a *LimitedReader. 
        /// </summary>
        public static Reader LimitReader(Reader r, long n)
        {
            return new LimitedReader(r, n);
        }

        /// <summary>
        /// MultiReader returns a Reader that's the logical concatenation of the provided input readers.
        /// They're read sequentially. Once all inputs have returned EOF, Read will return EOF.
        /// If any of the readers return a non-nil, non-EOF error, Read will return that error. 
        /// </summary>
        public static Reader MultiReader(params Reader[] readers)
        {
            return readers[0];
        }

        /// <summary>
        /// TeeReader returns a Reader that writes to w what it reads from r.
        /// All reads from r performed through it are matched with corresponding writes to w.
        /// There is no internal buffering - the write must complete before the read completes.
        /// Any error encountered while writing is reported as a read error. 
        /// </summary>
        public static Reader TeeReader(Reader r, Writer w)
        {
            return new TeeReader(r, w);
        }

        /// <summary>
        /// NewSectionReader returns a SectionReader that reads from r starting at offset off and stops with EOF after n bytes. 
        /// </summary>
        public static SectionReader NewSectionReader(ReaderAt r, long off, long n)
        {
            return new SectionReader(r, off, off, off + n);
        }

        /// <summary>
        ///  MultiWriter creates a writer that duplicates its writes to all the provided writers, similar to the Unix tee(1) command.
        ///  Each write is written to each listed writer, one at a time.If a listed writer returns an error,
        ///  that overall write operation stops and returns the error; it does not continue down the list.
        /// </summary>
        public static Writer MultiWriter(params Writer[] writers)
        {
            return writers[0];
        }
    }
}
