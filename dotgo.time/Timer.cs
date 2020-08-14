
using System;

namespace dotgo.time
{
    public struct Timer
    {
        public chan<Time> C;

        public bool Reset(Duration d)
        {
            return false;
        }

        public bool Stop()
        {
            return false;
        }
    }
}
