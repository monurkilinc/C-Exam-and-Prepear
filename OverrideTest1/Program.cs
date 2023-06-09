using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTest1
{
    class TestOverride
    {
        public class Employee
        {
            public string Name { get; }
            protected decimal _basepay;

            public Employee(string name, decimal basepay)
            {
                Name = name;
                _basepay = basepay;

            }

            public virtual decimal CalculatePay()
            {
                return _basepay;
            }
        }
        public class SalesEmployee : Employee
        {
            private decimal _salesbonus;
            public SalesEmployee(string name, decimal basepay, decimal salesbonus) : base(name, basepay)
            {
                _salesbonus = salesbonus;

            }
            public override decimal CalculatePay()
            {
                return _basepay + _salesbonus;
            }
        }

        static void Main(string[] args)
        {
            var employee1 = new SalesEmployee("Alice", 1000, 500);
            var employee2 = new Employee("Bob", 1200);

            Console.WriteLine($"Employee1 {employee1.Name} earned: {employee1.CalculatePay()}");
            Console.WriteLine($"Employee2 {employee2.Name} earned: {employee2.CalculatePay()}");

        }


    }
}