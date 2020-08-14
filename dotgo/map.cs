
using System.Collections.Generic;

namespace dotgo
{
    public class map<T, U>
    {
        private Dictionary<T, U> content;
        private int capacity;

        internal map(int cap)
        {
            content = new Dictionary<T, U>(cap);
            capacity = cap;
        }

        public U this[T key]
        {
            get
            {
                content.TryGetValue(key, out U val);
                return val;
            }
            set
            {
                if (content.ContainsKey(key))
                {
                    content[key] = value;
                }
            }
        }

        internal void delete(T key)
        {
            content.Remove(key);
        }

        internal int cap()
        {
            return capacity;
        }

        internal int len()
        {
            return content.Count;
        }
    }
}
