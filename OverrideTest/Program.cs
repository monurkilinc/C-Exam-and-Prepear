using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTest
{
    abstract class Shape
    {
        public abstract int GetArea();
    }

    class Square:Shape
    {
        private int _side;
        public Square(int n)=>_side = n;

        public override int GetArea() => _side*_side;
        

        static void Main(string[] args)
        {
            var sq=new Square(10);
            Console.WriteLine($"Area of the square = {sq.GetArea()}");
        }
    }
}
