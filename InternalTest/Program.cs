using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalTest
{
    class User
    {
        internal string Name;
        internal string Location;
        internal int Age;

        internal void GetUserDetails()
        {
            Console.WriteLine("Name={0}", Name);
            Console.WriteLine("Location={0}",Location);
            Console.WriteLine("Age={0}",Age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            User user= new User();
            user.Name = "Onur";
            user.Location = "ISTANBUL";
            user.Age = 28;

            user.GetUserDetails();
            Console.WriteLine("\n Press Enter key to Exit...");
            Console.ReadLine();
        }
    }
}
