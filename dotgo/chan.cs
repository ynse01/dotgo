
using System.Collections.Generic;

namespace dotgo
{
    public class chan<T>
    {
        private List<T> content = new List<T>();
        private object syncRoot = new object();

        public chan<T> Send(T value) {
            lock (syncRoot)
            {
                content.Add(value);
                return this;
            }
        }

        public T Receive()
        {
            lock (syncRoot)
            {
                var val = content[0];
                content.RemoveAt(0);
                return val;
            }
        }

        internal int cap()
        {
            return content.Count;
        }

        internal int len()
        {
            return content.Count;
        }
    }
}
