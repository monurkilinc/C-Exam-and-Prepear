using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTest6
{
    public abstract class GeekForGeeks
    {
        public abstract void gfg();
    }

    public class Geek1 : GeekForGeeks
    {
        public override void gfg()
        {
            Console.WriteLine("class Geek1");
        }
    }

    public class Geek2 : GeekForGeeks
    {
        public override void gfg()
        {
            Console.WriteLine("class Geek2");
        }

    }



    public class Program
    {
        public static void Main(string[] args)
        {
            GeekForGeeks g;

            g = new Geek1();
            g.gfg();

            g = new Geek2();
            g.gfg();


        }
    }
}
