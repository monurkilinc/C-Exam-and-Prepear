using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest1
{
    interface IPolygon
    {
        void calculateArea(int a , int b);  
    }

    interface IColor
    {
        void getColor();
    }
    
    class Rectangle : IPolygon, IColor
    {
        //IPolygon interface implementasyonu
        public void calculateArea(int a , int b)
        {
            int area = a * b;
            Console.WriteLine("Area of Rectangle : "+ area);
        }
        public void getColor()
        {
            Console.WriteLine("Red Rectangle");
        }

    }

     class Program
     {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.calculateArea(5, 6);
            rect.getColor();
        }
     }
}
