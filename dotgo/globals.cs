using System;
using System.Linq;

namespace dotgo
{
    public static class globals
    {
        public static T[] append<T>(T[] slice, params T[] elems)
        {
            return slice.Concat(elems).ToArray();
        }

        public static int cap(object v)
        {
            int cap = 0;
            Type target = v.GetType();
            var capMethod = target.GetMethod("cap");
            if (capMethod != null)
            {
                cap = (int)capMethod.Invoke(v, null);
            }
            return cap;
        }

        public static void close<T>(chan<T> c)
        {
            //TODO: Implement
        }

        public static complex64 Complex(float r, float i) {
            return new complex64(r, i);
        }

        public static complex128 Complex(double r, double i) {
            return new complex128(r, i);
        }

        public static int copy<T>(T[] dst, T[] src)
        {
            Array.Copy(src, dst, src.Length);
            return src.Length;
        }

        public static void delete<T, U>(map<T, U> m, T key)
        {
            m.delete(key);
        }

        public static float imag(complex64 c)
        {
            return c.i;
        }

        public static double imag(complex128 c)
        {
            return c.i;
        }

        public static int len(object v)
        {
            int len = 0;
            Type target = v.GetType();
            var lenMethod = target.GetMethod("len");
            if (lenMethod != null)
            {
                len = (int)lenMethod.Invoke(v, null);
            }
            return len;
        }

        public static T make<T>(params int[] size)
        {
            //TODO: Implement
            return default(T);
        }

        public static object make(Type t, params int[] size)
        {
            //TODO: Implement
            return null;
        }

        public static void panic(string message)
        {
            //TODO: Implement
        }

        public static void print(params object[] args)
        {
            foreach(var item in args)
            {
                Console.Write(item);
            }
        }

        public static void println(params object[] args)
        {
            print(args);
            Console.WriteLine();
        }

        public static float real(complex64 c)
        {
            return c.r;
        }

        public static double real(complex128 c)
        {
            return c.r;
        }

        public static void recover()
        {
            //TODO: Implement
        }
    }
}
