
using System;
using MonthType = dotgo.time.Month;
using WeekdayType = dotgo.time.Weekday;

namespace dotgo.time
{
    // TODO: Timezone implementation
    public struct Time
    {
        private static DateTime zero = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private DateTime utc;
        private ptr<Location> loc;

        internal Time(DateTime utc, ptr<Location> loc)
        {
            this.utc = utc;
            this.loc = loc;
        }

        public Time Add(Duration d)
        {
            var u = utc.Add((TimeSpan)d);
            return new Time(u, loc);
        }

        public Time AddDate(int years, int months, int days) 
        {
            var u = utc.AddYears(years);
            u = u.AddMonths(months);
            u = u.AddDays(days);
            return new Time(u, loc);
        }

        public bool After(Time u)
        {
            return utc.CompareTo(u.utc) > 0;
        }

        public byte[] AppendFormat(byte[] b, string layout)
        {
            // TODO: Implement
            return b;
        }

        public bool Before(Time u)
        {
            return utc.CompareTo(u.utc) < 0;
        }

        public (int hour, int min, int sec) Clock()
        {
            var hour = utc.Hour;
            var min = utc.Minute;
            var sec = utc.Second;
            return (hour, min, sec);
        }

        public struct timeTimeDateReturn
        {
            public int year;
            public Month month;
            public int day;
        }

        public (int year, MonthType month, int day) Date()
        {
            var year = utc.Year;
            var month = MonthType.FromDateTime(utc);
            var day = utc.Day;
            return (year, month, day);
        }

        public int Day()
        {
            return utc.Day;
        }

        public bool Equal(Time u)
        {
            var tLoc = loc.Dereferenced;
            var uLoc = u.loc.Dereferenced;
            return tLoc.Equals(uLoc) && utc.Equals(u.utc);
        }

        public string Format(string layout)
        {
            // TODO: Implement
            return layout;
        }

        public int Hour()
        {
            return utc.Hour;
        }

        public (int year, int week) ISOWeek()
        {
            var year = utc.Year;
            // TODO: Calculate week number
            var week = 0;
            return (year, week);
        }

        public Time In(ptr<Location> loc)
        {
            return new Time(utc, loc);
        }

        public bool IsZero()
        {
            return utc.Equals(zero);
        }

        public Time Local()
        {
            return this;
        }

        public ptr<Location> Location()
        {
            return loc;
        }

        public int Minute()
        {
            return utc.Minute;
        }

        public MonthType Month()
        {
            return MonthType.FromDateTime(utc);
        }

        public int NanoSecond()
        {
            return 0;
        }

        public Time Round(Duration m)
        {
            // TODO: Implement
            return this;
        }

        public int Second()
        {
            return utc.Second;
        }

        public string String()
        {
            return utc.ToString();
        }
        public Duration Sub(Time t)
        {
            return new Duration();
        }

        public Time Truncate(Duration d)
        {
            // TODO: Implement
            return this;
        }

        public Time UTC()
        {
            return new Time(utc, time.UTC);
        }

        public long Unix()
        {
            return utc.Ticks - epoch.Ticks;
        }

        public long UnixNano()
        {
            return Unix() * 1000L * 1000L;
        }

        public WeekdayType WeekDay()
        {
            return WeekdayType.FromDateTime(utc);
        }

        public int Year()
        {
            return utc.Year;
        }

        public int YearDay()
        {
            return utc.DayOfYear;
        }

        public Time Zone(string name, int offset)
        {
            var loc = new ptr<Location>(new Location(name, offset));
            return new Time(utc, loc);
        }
    }
}
