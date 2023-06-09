using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCodeTest1
{
    public class Author
    {
        public string FirstName;
        public string LastName;

        public Author(string fname, string lname)
        {

            FirstName = fname;
            LastName = lname;
        }

        public void Show()
        {
            Console.WriteLine("First Name=" + FirstName);
            Console.WriteLine("Last Name=" + LastName);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("Onur", "Kılınç");

            Console.WriteLine("Author Details:");
            a1.Show();

            Console.WriteLine("Hash code of object is:{0}",a1.GetHashCode());

        }
    }
}
