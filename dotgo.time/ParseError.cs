
namespace dotgo.time
{
    public struct ParseError
    {
        public string Layout;
        public string Value;
        public string LayoutElem;
        public string ValueElem;
        public string Message;

        public string Error()
        {
            return Message;
        }
    }
}
