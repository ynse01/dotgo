
namespace dotgo.io
{
    /// <summary>
    /// A PipeReader is the read half of a pipe. 
    /// </summary>
    public struct PipeReader : Reader
    {
        /// <summary>
        /// Read implements the standard Read interface: it reads data from the pipe, blocking until a writer arrives
        /// or the write end is closed.
        /// If the write end is closed with an error, that error is returned as err; otherwise err is EOF. 
        /// </summary>
        public (int n, error err) Read(byte[] p)
        {
            return (0, error.Nil);
        }

        /// <summary>
        /// Close closes the reader; subsequent writes to the write half of the pipe will return the error ErrClosedPipe.
        /// </summary>
        public error Close()
        {
            return CloseWithError(io.ErrClosedPipe);
        }

        /// <summary>
        ///  CloseWithError closes the reader; subsequent writes to the write half of the pipe will return the error err.
        ///  CloseWithError never overwrites the previous error if it exists and always returns nil.
        /// </summary>
        public error CloseWithError(error err)
        {
            return error.Nil;
        }
    }
}
