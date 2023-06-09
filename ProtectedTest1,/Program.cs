using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedTest1_
{
    class User
    {
        protected string Name;
        protected string Location;
        protected int Age;
        protected void GetUserDetails()
        {
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("Location:{0}",Location);
            Console.WriteLine("Age:{0}",Age);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Aynı classta olmadığı için hata verir!
            User user = new User();
            //user.Name = "Onur KILINÇ";
            //user.Location = "ISTANBUL";
            //user.Age = "28";

            //user.GetUserDetails();
            Console.WriteLine("/n Press Enter Key to Exit....");
            Console.ReadLine();

        }
    }
}
