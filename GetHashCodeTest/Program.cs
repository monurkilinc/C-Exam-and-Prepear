using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCodeTest
{
    class Program
    {
       public static void Main(string[] args)
        {
            Object obj=new Object();
            Type t=obj.GetType();

            Console.WriteLine("Type is:{0}",t);
            Console.WriteLine("Hash Code:{0}",t.GetHashCode());



        }
    }
}
