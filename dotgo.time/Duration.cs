
using System.Data.Common;
using System.Threading;

namespace dotgo
{
    public struct Duration
    {
        private long nano;

        public Duration(long nano)
        {
            this.nano = nano;
        }

        public long Microseconds()
        {
            return nano / 1000;
        }

        public long MilliSeconds()
        {
            return Microseconds() / 1000;
        }

        public long NanoSeconds()
        {
            return nano;
        }

        public float Seconds()
        {
            return MilliSeconds() / 1000f;
        }

        public float Minutes()
        {
            return Seconds() / 60f;
        }

        public float Hours()
        {
            return Minutes() / 60f;
        }

        public Duration Round(Duration m)
        {
            return this;
        }

        public string String()
        {
            return ToString();
        }

        public Duration Truncate(Duration m)
        {
            return this;
        }

        public static Duration operator *(Duration d, int scalar)
        {
            return new Duration(d.nano * scalar);
        }

        public static Duration operator *(int scalar, Duration d)
        {
            return new Duration(d.nano * scalar);
        }

        public static Duration operator /(Duration d, int scalar)
        {
            return new Duration(d.nano / scalar);
        }

        public static Duration operator /(int scalar, Duration d) {
            return new Duration(d.nano / scalar);
        }
    }
}
