
namespace dotgo
{
    public class chan<T>
    {
        public chan<T> input(T value) {
            return this;
        }

        public T output()
        {
            return default(T);
        }
    }
}
