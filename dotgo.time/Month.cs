
using System;

namespace dotgo.time
{
    public struct Month
    {
        public static Month January = new Month(1);
        public static Month February = new Month(2);
        public static Month March = new Month(3);
        public static Month April = new Month(4);
        public static Month May = new Month(5);
        public static Month June = new Month(6);
        public static Month July = new Month(7);
        public static Month August = new Month(8);
        public static Month September = new Month(9);
        public static Month October = new Month(10);
        public static Month November = new Month(11);
        public static Month December = new Month(12);

        public static Month FromDateTime(DateTime dt)
        {
            return new Month(dt.Month);
        }

        private static readonly string[] strings = new[]
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "November", "December"
        };

        private int m;

        private Month(int m)
        {
            this.m = m;
        }

        public string String()
        {
            return strings[m - 1];
        }
    }
}
