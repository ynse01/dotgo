using System;
using System.Collections.Generic;
using System.Text;

namespace dotgo.io
{
    public class errors
    {
        public static error New(string name)
        {
            return new error(name);
        }
    }

    public struct error
    {
        private string err;

        public error(string err)
        {
            this.err = err;
        }

        public string Error()
        {
            return err;
        }
    }
}
