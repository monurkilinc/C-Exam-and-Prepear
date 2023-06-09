using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTest8
{
    abstract class AbstractClass
    {

        public abstract int MultiplyTwoNumbers(int n1, int n2);
        public abstract int AddTwoNumbers(int n1, int n2);
    }

    class Derived : AbstractClass
    {
        public override int AddTwoNumbers(int n1, int n2)
        {
            return n1 + n2;
        }
        public override int MultiplyTwoNumbers(int n1, int n2)
        {
            return (n1 * n2);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Derived d = new Derived();
            Console.WriteLine("Addition : {0} \nMultiplication : {1}", d.AddTwoNumbers(7, 8), d.MultiplyTwoNumbers(8, 7));

        }
    }
}
