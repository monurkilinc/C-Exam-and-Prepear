using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee2
    {
        private readonly string _name = "Onur ,Kılınç ";
        private readonly double _salary = 100.0;

        public string GetName()
        {
            return _name;
        }
        public double Salary()
        {
            return _salary;
        }


    }

    class PrivateTest
    {
        static void Main(string[] args)
        {
            var e = new Employee2();

            string n = e.GetName();

            double s = e.Salary();


            Console.Write($"Ad={0}, Satış={1}", n, s);
        }
    }
}
