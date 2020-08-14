
using System;

namespace dotgo.time
{
    public struct Weekday
    {
        public static readonly Weekday Sunday = new Weekday(0);
        public static readonly Weekday Monday = new Weekday(1);
        public static readonly Weekday Tuesday = new Weekday(2);
        public static readonly Weekday Wednesday = new Weekday(3);
        public static readonly Weekday Thursday = new Weekday(4);
        public static readonly Weekday Friday = new Weekday(5);
        public static readonly Weekday Saturday = new Weekday(6);

        public static Weekday FromDateTime(DateTime dt)
        {
            return new Weekday((int)dt.DayOfWeek);
        }


        private static readonly string[] strings = new[]
        {
            "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
        };

        private int day;
        private Weekday(int day)
        {
            this.day = day;
        }

        public string String()
        {
            return strings[day];
        }
    }
}
