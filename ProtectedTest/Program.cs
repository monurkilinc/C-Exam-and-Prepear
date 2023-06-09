using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedTest
{
    class Student
    {
        protected string name = "Onur";
    }



    class Program

    {
        static void Main(string[] args)
        {
            Student student1= new Student();

            //Hata vermesinin sebebi protected kullanıldığı için sadece aynı classtan veya kalıtım yoluyla kullanılması gerekir

            //Console.WriteLine("Ad=" + student1.name);
            Console.ReadLine();
        }
    }
}
