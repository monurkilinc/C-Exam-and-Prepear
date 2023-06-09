using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest6
{
    public class Dog
    {
        String Name;
        String Breed;
        int Age;
        String Color;

        public Dog(String name, String breed, int age,String color)
        {
            Name = name;
            Breed = breed;
            Age = age;
            Color = color;
        }

        public String GetName() { return Name; }
        public String GetBreed() { return Breed; }
        public int GetAge() { return Age; }
        public String GetColor() { return Color; }

        public String DogInfo()
        {
            return ("Hi! My name is " + GetName() + 
                ".\nMy breed,age and color are " + GetBreed() + GetAge() + GetColor());
        }

       public static void Main(string[] args)
        {
            Dog dog = new Dog("tuffy", "papillion", 5, "white");
            Console.WriteLine(dog.DogInfo());
        }
    }
}
