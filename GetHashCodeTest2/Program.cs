using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCodeTest2
{
    public struct Value
    {
        private int v1;
        private int v2;
        private int v3;

        public Value(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
        public override int GetHashCode()
        {
            return Tuple.Create(v1,v2,v3).GetHashCode();
        }
    }



    public class Program
    {
        public static void Main(string[] args)
        {
            Value v = new Value(3,4,5);
            Console.WriteLine(v);
            Console.WriteLine(v.GetHashCode());

            v= new Value(6,7,8);
            Console.WriteLine(v);
            Console.WriteLine(v.GetHashCode());

            v= new Value(20,30,40);
            Console.WriteLine(v);
            Console.WriteLine(v.GetHashCode());
        }
    }
}
