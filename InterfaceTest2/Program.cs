using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest2
{
    interface IPolygon
    {
        void calculateArea(int a,int b);    
    }
    class Rectangle : IPolygon
    {
        public void calculateArea(int a,int b)
        {
            int area = a * b;
            Console.WriteLine("Area of Rectangle : "+ area);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Interfaceden alınan referans değeri.Abstract classında yoktur
            IPolygon r1 = new Rectangle();
            r1.calculateArea(6,7);


        }
    }
}
