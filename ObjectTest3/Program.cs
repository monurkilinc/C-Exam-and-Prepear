using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest3
{
    public class Users
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Users(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public void GetUserDetails()
        {
            Console.WriteLine("Name={0},Age={1}", Name, Age);
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Users user = new Users("Onur Kılınç", 30);
            user.GetUserDetails();
            Console.WriteLine("Press Enter key to Exit...");
            Console.ReadLine();


        }
    }
}
