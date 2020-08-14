
namespace dotgo.time
{
    public struct Location
    {
        private string name;
        private int offset;

        private Location(string name, int offset)
        {
            this.name = name;
            this.offset = offset;
        }

        public string String()
        {
            return name;
        }
    }
}
