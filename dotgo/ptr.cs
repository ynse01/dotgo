
namespace dotgo
{
    public class ptr<T> where T: struct
    {
        private T val;

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
