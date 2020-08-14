
using System;

namespace dotgo.time
{
    public static class time
    {
        public static string ANSIC = "Mon Jan _2 15:04:05 2006";
        public static string UnixDate = "Mon Jan _2 15:04:05 MST 2006";
        public static string RubyDate = "Mon Jan 02 15:04:05 -0700 2006";
        public static string RFC822 = "02 Jan 06 15:04 MST";
        public static string RFC822Z = "02 Jan 06 15:04 -0700";
        public static string RFC850 = "Monday, 02-Jan-06 15:04:05 MST";
        public static string RFC1123 = "Mon, 02 Jan 2006 15:04:05 MST";
        public static string RFC1123Z = "Mon, 02 Jan 2006 15:04:05 -0700";
        public static string RFC3339 = "2006-01-02T15:04:05Z07:00";
        public static string RFC3339Nano = "2006-01-02T15:04:05.999999999Z07:00";
        public static string Kitchen = "3:04PM";

        public static ptr<Location> UTC;

        public static string Stamp = "Jan _2 15:04:05";
        public static string StampMilli = "Jan _2 15:04:05.000";
        public static string StampMicro = "Jan _2 15:04:05.000000";
        public static string StampNano = "Jan _2 15:04:05.000000000";

        public static Duration NanoSecond = new Duration(1);
        public static Duration MicroSecond = 1000 * NanoSecond;
        public static Duration MilliSecond = 1000 * MicroSecond;
        public static Duration Second = 1000 * MicroSecond;
        public static Duration Minute = 60 * Second;
        public static Duration Hour = 60 * Minute;

        public static chan<Time> After(Duration d)
        {
            return default(chan<Time>);
        }

        public static void Sleep(Duration m)
        {

        }

        public static chan<Time> Tick(Duration d)
        {
            return default(chan<Time>);
        }

        public struct timeParseDurationReturn
        {
            public Duration d;
            public error err;
        }

        public static timeParseDurationReturn ParseDuration(string s)
        {
            return new timeParseDurationReturn();
        }

        public static Duration Since(Time t)
        {
            return Now().Sub(t);
        }

        public static Duration Until(Time t)
        {
            return t.Sub(Now());
        }

        public struct timeLocationReturn
        {
            public ptr<Location> loc;
            public error err;
        }

        public static timeLocationReturn FixedZone(string name, int offset)
        {
            return new timeLocationReturn();
        }

        public static timeLocationReturn LoadLocation(string name)
        {
            return new timeLocationReturn();
        }

        public static timeLocationReturn LoadLocationFromTZData(string name, byte[] data)
        {
            return new timeLocationReturn();
        }

        public static Time Date(int year, Month month, int day, int hour, int min, int sec, int nsec, ptr<Location> loc)
        {
            return new Time();
        }

        public static Time Now()
        {
            return new Time();
        }

        public struct timeParseReturn
        {
            public Time time;
            public error err;
        }

        public static timeParseReturn Parse(string format, string value)
        {
            return new timeParseReturn();
        }

        public static timeParseReturn ParseInLocation(string format, string value, ptr<Location> loc)
        {
            return new timeParseReturn();
        }

        public static Time Unix(long sec, long nsec)
        {
            return new Time();
        }

        public static ptr<Timer> AfterFunc(Duration d, Action func)
        {
            return default(ptr<Timer>);
        }

        public static ptr<Timer> NewTimer(Duration d)
        {
            return default(ptr<Timer>);
        }
    }
}
