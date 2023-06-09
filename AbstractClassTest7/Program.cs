using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTest7
{
    abstract class AreaClass
    {
        abstract public int Area();
    }

    class Square : AreaClass
    {
        int side = 0;

        public Square(int n)
        {
            side = n;
        }

        public override int Area()
        {
            return side * side;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Square s = new Square(6);
            Console.WriteLine("Area= " + s.Area());
           
        }
    }
}
