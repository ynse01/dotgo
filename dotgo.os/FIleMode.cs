
namespace dotgo.os
{
    public struct FileMode
    {
        public static FileMode ModeDir = new FileMode(0x40000000);
        public static FileMode ModeAppend = new FileMode(0x20000000);
        public static FileMode ModeExclusive = new FileMode(0x10000000);
        public static FileMode ModeTemporary = new FileMode(0x08000000);
        public static FileMode ModeSymlink = new FileMode(0x04000000);
        public static FileMode ModeDevice = new FileMode(0x02000000);
        public static FileMode ModeNamedPipe = new FileMode(0x01000000);
        public static FileMode ModeSocket = new FileMode(0x00800000);
        public static FileMode ModeSetuid = new FileMode(0x00400000);
        public static FileMode ModeSetgid = new FileMode(0x00200000);
        public static FileMode ModeCharDevice = new FileMode(0x00100000);
        public static FileMode ModeSticky = new FileMode(0x00080000);
        public static FileMode ModeIrregular = new FileMode(0x00040000);

        public static FileMode ModeType = new FileMode(0xfffc0000);

        private uint mode;

        private FileMode(uint mode)
        {
            this.mode = mode;
        }

        public FileMode Perm()
        {
            uint perm = mode ^ ModeIrregular.mode;
            return new FileMode(perm);
        }

        public bool IsRegular()
        {
            return mode < ModeIrregular.mode;
        }

        public bool IsDir()
        {
            return (mode & ModeDir.mode) > 0;
        }

        public string String()
        {
            return ToString();
        }
    }
}
