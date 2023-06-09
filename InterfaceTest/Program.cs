using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    interface IPolygon
    {
        void calculateArea(int x, int y);   
    }

    class Rectangle : IPolygon
    {
        public void calculateArea(int x, int y)
        {
            int area = x * y;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.calculateArea(100, 200);
        }
    }
}
