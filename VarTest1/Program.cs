using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "aPpLe", "bLUEbErry", "ChErY" };

            var upperLowerWords=

                from w in words
                select new {Upper=w.ToUpper(), Lower=w.ToLower()};
            foreach(var ul in upperLowerWords)
            {
                Console.WriteLine("Uppercase:{0},Lowercase:{1}",ul.Upper,ul.Lower);
            }


        }
    }
}
