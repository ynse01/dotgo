
using System;
using MonthType = dotgo.time.Month;
using WeekdayType = dotgo.time.Weekday;

namespace dotgo.time
{
    public struct Time
    {
        private static DateTime zero = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public Time Add(Duration d)
        {
            return new Time();
        }

        public Time AddDate(int years, int months, int days) 
        {
            return new Time();
        }

        public bool After(Time u)
        {
            return true;
        }

        public byte[] AppendFormat(byte[] b, string layout)
        {
            return b;
        }

        public bool Before(Time u)
        {
            return true;
        }

        public struct timeTimeClockReturn
        {
            public int hour;
            public int min;
            public int sec;
        }

        public timeTimeClockReturn Clock()
        {
            return new timeTimeClockReturn();
        }

        public struct timeTimeDateReturn
        {
            public int year;
            public Month month;
            public int day;
        }

        public timeTimeDateReturn Date()
        {
            return new timeTimeDateReturn();
        }

        public int Day()
        {
            return 0;
        }

        public bool Equal(Time u)
        {
            return false;
        }

        public string Format(string layout)
        {
            return layout;
        }

        public int Hour()
        {
            return 0;
        }

        public struct timeTimeISOWeekReturn
        {
            public int year;
            public int week;
        }

        public timeTimeISOWeekReturn ISOWeek()
        {
            return new timeTimeISOWeekReturn();
        }

        public Time In(ptr<Location> loc)
        {
            return this;
        }

        public bool IsZero()
        {
            return true;
        }

        public Time Local()
        {
            return this;
        }

        public ptr<Location> Location()
        {
            return default(ptr<Location>);
        }

        public int Minute()
        {
            return 0;
        }

        public MonthType Month()
        {
            return MonthType.January;
        }

        public int NanoSecond()
        {
            return 0;
        }

        public Time Round(Duration m)
        {
            return this;
        }

        public int Second()
        {
            return 0;
        }

        public string String()
        {
            return ToString();
        }
        public Duration Sub(Time t)
        {
            return new Duration();
        }

        public Time Truncate(Duration d)
        {
            return this;
        }

        public Time UTC()
        {
            return this;
        }

        public long Unix()
        {
            return 0;
        }

        public long UnixNano()
        {
            return 0;
        }

        public WeekdayType WeekDay()
        {
            return WeekdayType.Monday;
        }

        public int Year()
        {
            return 0;
        }

        public int YearDay()
        {
            return 0;
        }

        public Time Zone(string name, int offset)
        {
            return this;
        }
    }
}
