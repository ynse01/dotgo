
using System.Data.Common;

namespace dotgo
{
    public struct error
    {
        private string err;

        public static readonly error Nil = new error("nil");

        public error(string err)
        {
            this.err = err;
        }

        public string Error()
        {
            return err;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(error left, error right)
        {
            return string.CompareOrdinal(left.err, right.err) == 0;
        }

        public static bool operator !=(error left, error right)
        {
            return string.CompareOrdinal(left.err, right.err) != 0;
        }
    }
}
