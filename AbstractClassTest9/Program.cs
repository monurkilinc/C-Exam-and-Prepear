using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTest9
{
    abstract class absClass
    {
        protected int myNumber;

        public abstract int numbers { get; set; }

    }

    class absDerived:absClass 
    { 
        public override int numbers
        {

            get { return myNumber; }
            set { myNumber = value; }
        }    
    }
    class Program
    {
        public static void Main(string[] args)
        {
            absDerived d= new absDerived();
            d.numbers = 5;
            Console.WriteLine(d.numbers);

        }
    }
}
