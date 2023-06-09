using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    abstract class Language
    {
        //  abstract classta metot tanımladık
        public void display() { Console.WriteLine("Non abstract method"); }

    }
    //inherit edildi
    class Program:Language
    {
        static void Main(string[] args)
        {

            Program obj = new Program();
            //abstract classtaki metot cagrılıp ekrana yazdırıldı
            obj.display();
            Console.ReadLine();

        }
    }
}
