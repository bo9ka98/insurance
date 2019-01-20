using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Class1
    {
        public int publicVar;
        protected int protectedVar;
        internal int internalVar;
    }

    class Class2 : Class1
    {
        public void mmaann()
        {

        }
    }

    class Maini
    {
        public static void maini(string[] str)
        {
            Class1 vart1 = new Class1();
            Class2 vart2 = new Class2();
        }
    }
}
