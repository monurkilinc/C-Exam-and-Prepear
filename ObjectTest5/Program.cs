using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest5
{
    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Onur",28);
            Console.WriteLine("Person 1 Name={0} Age={1}",person.Name,person.Age);

            Person p2 = person;
            p2.Name = "Sena";
            p2.Age = 25;
            Console.WriteLine("Person 2 Name={0} Age={1}", p2.Name, p2.Age);

            Console.WriteLine("Person 1 Name={0} Age={1}", person.Name, person.Age);


        }
    }
}
