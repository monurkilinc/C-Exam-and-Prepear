using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeTest1
{
    [Serializable]
    public class Employee
    {
        private string Name;
        public string name
        {
            get { return name; }
            set { name = value; }

        }

        private string Phone;
        public string phone
        {
            get { return Phone; }
            set { Phone = value; }
        }

        private DateTime DoB;
        public DateTime dob
        {
            get { return DoB; }
            set { DoB = value; }
        }

        private int Salary;
        public int salary
        {
            get { return Salary; }
            set { Salary = value; }
        }
        [NonSerialized]
        public string additionalInfo;


    }
   

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
