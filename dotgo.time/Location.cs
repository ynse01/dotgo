
namespace dotgo.time
{
    public struct Location
    {
        private string name;
        private int offset;

        internal Location(string name, int offset)
        {
            this.name = name;
            this.offset = offset;
        }

        public bool Equals(ptr<Location> other)
        {
            return string.CompareOrdinal(name, other.Dereferenced.name) == 0;
        }

        public string String()
        {
            return name;
        }
    }
}
