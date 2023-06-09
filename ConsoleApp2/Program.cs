using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PointTest
    {

        //Eğer public yerine private kullanılırsa PointTest.y koruma düzeyi nedeniyle erişilemiyor hatası alınır!

        //public e her yerden erişim sağlanabilir.Erişim kısıtlama yoktur!
        public int x;
        public int y;


    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new PointTest();
            p.x = 10;
            p.y = 20;
            Console.WriteLine($"x={p.x}, y={p.y}");

        }
    }


}
