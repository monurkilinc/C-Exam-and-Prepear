using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest
{
    class Dog
    {
        string breed;
        public void Bark() 
        {
            Console.WriteLine("Bark Bark Bark!!!");
        }
        static void Main(string[] args)
        {
            //Dog objecti olarak bulldog türetildi
            Dog bullDog=new Dog();
            
            //Bulldog objecti çocuk sahibi oldu ve isim verildi
            bullDog.breed = "Bull Dog";
            Console.WriteLine(bullDog.breed);

            //Yavrumuz havladı
            bullDog.Bark();
            Console.ReadLine();
        }
    }
}
