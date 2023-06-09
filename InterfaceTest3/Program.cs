using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest3
{
    interface IPolygon
    {
        void calculateArea();
    }

    class Rectangle : IPolygon
    {
        public void calculateArea()
        {
            int a = 8;
            int b = 10;
            int area = a * b;
            Console.WriteLine("Area of Rectangle : " + area);
        }
    }

    class Square : IPolygon
    {
        public void calculateArea()
        {
            int a = 8;
            int area = a * a;
            Console.WriteLine("Area of Square : " + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.calculateArea();

            Square square = new Square();
            square.calculateArea();

        }
    }
}
