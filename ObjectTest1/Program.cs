using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest1
{
    class Employee  
    {
        string department;
        static void Main(string[] args)
        {
            Employee onur= new Employee();
            onur.department = "Full Stack";
            Console.WriteLine("Onur:"+onur.department);

            Employee sena= new Employee();
            sena.department = "Sales & Management";
            Console.WriteLine("Sena:"+sena.department);

            Console.ReadLine();



        }
    }
}
