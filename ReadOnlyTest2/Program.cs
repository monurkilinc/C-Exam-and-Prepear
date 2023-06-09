using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyTest2
{

    public struct Customer
    {
        public string Name { get; }
        public int Price { get; }


        //C# 8.0 dan sonra structure içinde readonly kullanımına izin verilir.struct readonly ile kurulursa herhangi bir hata alınmaz
        //public readonly string Product { get; }
        
        public string Product { get; }

        public Customer(string name, int price,string Product)
        {
            this.Name = name;
            this.Price = price;
            this.Product = Product; 
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Onur",7000, "IPAD");
            Console.WriteLine("Customer Name="+customer.Name);
            Console.WriteLine("Product="+customer.Product);
            Console.WriteLine("Price="+customer.Price);
        }
    }
}
