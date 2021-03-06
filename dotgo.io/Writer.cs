﻿
namespace dotgo.io
{
    /// <summary>
    ///  Writer is the interface that wraps the basic Write method.
    ///  Write writes len(p) bytes from p to the underlying data stream.
    ///  It returns the number of bytes written from p (0 <= n <= len(p)) and any error encountered that caused the write to stop early.
    ///  Write must return a non-nil error if it returns n<len(p). Write must not modify the slice data, even temporarily.
    ///  Implementations must not retain p. 
    /// </summary>
    public interface Writer
    {
        (int n, error err) Write(slice<byte> p);
    }
}
