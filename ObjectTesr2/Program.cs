using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTesr2
{
    class Employee
    {
        public string name;

        public void Work(string work)
        {
            Console.WriteLine("Work="+work);
        }
    }

    class EmployeeDrive
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine("Employee 1");

            e1.name = "Onur";
            Console.WriteLine("Name={0}", e1.name);

            e1.Work("Devoloper");

            Console.ReadLine();
           


        }
    }
}
