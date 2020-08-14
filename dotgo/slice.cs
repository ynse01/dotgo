
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
