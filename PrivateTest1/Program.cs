using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateTest1
{
    class Student
    {
        private string name = "Onur";
        private void print() 
        {
            Console.WriteLine("Hello from Student class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student classından obje oluşturduk
            Student student1= new Student();

            //Student classından name e erişim sağladık.Hata alınmasının sebebi aynı classtan erişim sağlanmaması


            //Console.WriteLine("Name:" + student1.name);

            //student1.Print();
            Console.ReadLine();
        }
    }
        
    
}
