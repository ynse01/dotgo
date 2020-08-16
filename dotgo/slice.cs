
using System;

namespace dotgo
{
    public class slice<T>
    {
        private ArraySegment<T> segment;

        public slice(T[] basis, int low, int high) {
            segment = new ArraySegment<T>(basis, low, high - low);
        }

        public T this[int index]
        {
            get
            {
                return segment.Array[index + segment.Offset];
            }
            set
            {
                segment.Array[index + segment.Offset] = value;
            }
        }

        public slice<T> piece(int low, int high)
        {
            return new slice<T>(segment.Array, segment.Offset + low, segment.Offset + high);
        }

        internal int cap()
        {
            return segment.Count;
        }

        internal int len()
        {
            return segment.Count;
        }
    }
}
