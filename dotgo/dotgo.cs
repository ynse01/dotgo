using System;
using System.Linq;

namespace dotgo
{
    public static class dotgo
    {
        public static T[] append<T>(this object o, T[] slice, params T[] elems)
        {
            return slice.Concat(elems).ToArray();
        }

        public static int cap(this object o, object v)
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

        public static void close<T>(this object o, chan<T> c)
        {
            //TODO: Implement
        }

        public static complex64 Complex(this object o, float r, float i) {
            return new complex64(r, i);
        }

        public static complex128 Complex(this object o, double r, double i) {
            return new complex128(r, i);
        }

        public static int copy<T>(this object o, T[] dst, T[] src)
        {
            Array.Copy(src, dst, src.Length);
            return src.Length;
        }

        public static void delete<T, U>(this object o, map<T, U> m, T key)
        {
            m.delete(key);
        }

        public static float imag(this object o, complex64 c)
        {
            return c.i;
        }

        public static double imag(this object o, complex128 c)
        {
            return c.i;
        }

        public static int len(this object o, object v)
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

        public static T make<T>(this object o, params int[] size)
        {
            //TODO: Implement
            return default(T);
        }

        public static object make(this object o, Type t, params int[] size)
        {
            //TODO: Implement
            return null;
        }

        public static void panic(this object o)
        {
            //TODO: Implement
        }

        public static void print(this object o, params object[] args)
        {
            foreach(var item in args)
            {
                Console.Write(item);
            }
        }

        public static void println(this object o, params object[] args)
        {
            print(args);
            Console.WriteLine();
        }

        public static float real(this object o, complex64 c)
        {
            return c.r;
        }

        public static double real(this object o, complex128 c)
        {
            return c.r;
        }

        public static void recover(this object o)
        {
            //TODO: Implement
        }
    }
}
