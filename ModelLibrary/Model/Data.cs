using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary.Model
{
    public class Data
    {
        private int a;
        private int b;

        public Data(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Data()
        {
        }

        public int A
        {
            get => a;
            set => a = value;
        }

        public int B
        {
            get => b;
            set => b = value;
        }
    }
}
