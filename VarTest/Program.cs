using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = 10;
     

            //Hata alınmasının sebebi x var ile int değeri aldı.string değer ataması yapılamaz
            //x = "Hello";
            Console.WriteLine($"Type is {x.GetType()} & value={x}");
            Console.ReadLine();
        }
    }
}
