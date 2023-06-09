using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest4
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }

        public Person(string name, int age, string job)
        {
            Name = name;
            Age = age;
            Job = job;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Onur",28,"Devoloper");
            Console.WriteLine("Person Name={0},Age={1},Person Job={2}",person1.Name,person1.Age,person1.Job);

            Person person2 = person1;

            person2.Name = "Sena";
            person2.Age = 25;
            person2.Job = "Sales&Management";

            Console.WriteLine("Person Name={0},Age={1},Person Job={2}", person2.Name, person2.Age, person2.Job);
            Console.WriteLine("Person Name={0},Age={1},Person Job={2}", person1.Name, person1.Age, person1.Job);
           
            
        }
    }
}
