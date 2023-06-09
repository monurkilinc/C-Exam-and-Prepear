using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTest3
{
    abstract class Animal
    {
        public Animal() 
        {
            Console.WriteLine("Animal Constructor here!!!");

        }
    }

    class Dog:Animal
    { 
        public Dog() 
        {
            Console.WriteLine("Dog Constructor here!!!");
        }
    
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.ReadLine();
        }
    }
}
