
namespace dotgo
{
    public struct rune
    {
        private int i;

        public rune(int i)
        {
            this.i = i;
        }

        public static implicit operator int(rune r)
        {
            return r.i;
        }

        public static implicit operator rune(int i)
        {
            return new rune(i);
        }
    }
}
