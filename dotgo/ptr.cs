
namespace dotgo
{
    public class ptr<T> where T: struct
    {
        private T val;

        public static ptr<T> Nil = new ptr<T>(default(T));

        public ptr(T val)
        {
            this.val = val;
        }

        public T Dereferenced
        {
            get
            {
                return val;
            }
        }
    }
}
