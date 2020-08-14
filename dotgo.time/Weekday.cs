
namespace dotgo.time
{
    public struct Weekday
    {
        public static Weekday Sunday = new Weekday(0);
        public static Weekday Monday = new Weekday(1);
        public static Weekday Tuesday = new Weekday(2);
        public static Weekday Wednesday = new Weekday(3);
        public static Weekday Thursday = new Weekday(4);
        public static Weekday Friday = new Weekday(5);
        public static Weekday Saturday = new Weekday(6);

        private int day;
        private Weekday(int day)
        {
            this.day = day;
        }
    }
}
