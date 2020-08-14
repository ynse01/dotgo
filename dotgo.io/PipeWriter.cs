
namespace dotgo.io
{
    /// <summary>
    /// A PipeWriter is the write half of a pipe. 
    /// </summary>
    public struct PipeWriter : Writer
    {
        /// <summary>
        /// Write implements the standard Write interface: it writes data to the pipe, blocking until one or more readers
        /// have consumed all the data or the read end is closed.
        /// If the read end is closed with an error, that err is returned as err; otherwise err is ErrClosedPipe. 
        /// </summary>
        public (int n, error err) Write(byte[] p)
        {
            return (0, error.Nil);
        }

        /// <summary>
        /// Close closes the writer; subsequent reads from the read half of the pipe will return no bytes and EOF. 
        /// </summary>
        /// <returns></returns>
        public error Close()
        {
            return CloseWithError(io.ErrClosedPipe);
        }

        /// <summary>
        ///  CloseWithError closes the writer; subsequent reads from the read half of the pipe will return no bytes and the error err, or EOF if err is nil.
        ///  CloseWithError never overwrites the previous error if it exists and always returns nil.
        /// </summary>
        public error CloseWithError(error err)
        {
            return error.Nil;
        }
    }
}
