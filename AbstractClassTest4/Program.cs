using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTest4
{
    abstract class MotorBike
    {
        public abstract void brake();
    }

    class SportsBike : MotorBike
    {
        public override void brake()
        {
            Console.WriteLine("SportsBike brake!!!");
        }
    }
    class MountainBike : MotorBike
    {
        public override void brake()
        {
            Console.WriteLine("Mountain Bike brake!!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SportsBike sp1 = new SportsBike();
            sp1.brake();

            MountainBike mb1 = new MountainBike();
            mb1.brake();
            Console.ReadLine();
        }
    }
}
