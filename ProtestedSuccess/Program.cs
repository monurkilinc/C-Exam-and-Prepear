using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtestedSuccess
{
    class User
    {
        protected string Name;
        protected string Location;
        protected int Age;

        protected void GetUserDetails()
        {
            Console.WriteLine("Name={0}", Name);
            Console.WriteLine("Location={0}", Location);
            Console.WriteLine("Age={0}", Age);
        }
    }
    class Program:User
    {
        static void Main(string[] args)
        {
            User u = new User();
            Program p = new Program();

            //Altta yorum satırı haline getirilen şekillerde kullanılamaz.Miras yoluyla kullanıldığı için p türünde
            // yeni bir class türetilip p parametresi ile kullanıldı.

            //u.Name = "Onur";
            p.Name = "Onur";

            //u.Location = "ISTANBUL";
            p.Location = "ISTANBUL";

            //u.Age = 28;
            p.Age = 28;

            //u.GetUserDetails();
            p.GetUserDetails();

            Console.WriteLine("/n Press Enter key to Exit...");
            Console.ReadLine();
        }
    }
}
