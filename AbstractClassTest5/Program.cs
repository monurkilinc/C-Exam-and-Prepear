using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTest5
{
    public abstract class Animal
    {
        public abstract string Sound { get; }
        public virtual void Move()
        {
            Console.WriteLine("I LIKE TO MOVE IT MOVE IT!!!");
        }
    }

    public class Cat: Animal
    {
        public override string Sound => "Miyavvvv";
        public override void Move() 
        {
            Console.WriteLine("Catwalk yapan kedi...");

        }
    }

    public class Dog : Animal
    {
        public override string Sound => "Hav Hav";
        public override void Move()
        {
            Console.WriteLine("Köpek gibi koş....");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals=new Animal[] { new Cat(),new Dog() };
            foreach(Animal animal in animals) 
            {
                Console.WriteLine($"The {animal.GetType().Name} goes {animal.Sound}");
                animal.Move();

            }

        }
    }
}
