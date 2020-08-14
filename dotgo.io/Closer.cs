
namespace dotgo.io
{
    /// <summary>
    ///  Closer is the interface that wraps the basic Close method.
    ///  The behavior of Close after the first call is undefined.Specific implementations may document their own behavior.
    /// </summary>
    public interface Closer
    {
        error Close();
    }
}
