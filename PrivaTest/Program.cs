using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivaTest
{
    class Employee2
    {
        private string _name = "Onur Kılınç ";
        private double _salary = 100.0;

        public string GetName()
        {
            return _name;
        }
        public double Salary()
        {
            return _salary;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            var e = new Employee2();

            string n = e.GetName();

            double s = e.Salary();


            Console.WriteLine($"Ad={n} Satış={s}");
        }
    }
}
