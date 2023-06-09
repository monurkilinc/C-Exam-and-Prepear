using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTest2
{
    abstract class Animal
    {
        protected string name;
        public abstract string Name { get;set; } 
    }
    class Dog:Animal
    { 
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.Name = "Kucu kucu";
            Console.WriteLine("Name: "+obj.Name);
            Console.ReadLine();
        }
    }
}
