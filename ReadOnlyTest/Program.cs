using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyTest
{
    class Test
    {
        public readonly string val1;
        public readonly string val2;
        public readonly string val3 = "Test Start";


        public Test(string a, string b)

        {
            val1 = a;
            val2 = b;

            Console.WriteLine("Display value of val1 {0}," + "and val2 {1}", val1, val2);

        }


        static void Main(string[] args)
        {
            Test ro = new Test("Test1","Test2");
        }

    }
}