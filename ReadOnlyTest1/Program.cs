using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyTest1
{
    public readonly struct Author
    {
        public readonly string Name;
        public readonly int Article;
        public readonly string Branch;

        public Author(string name, int article, string branch)
        {
            this.Name = name;
            this.Article = article;
            this.Branch = branch;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Author a=new Author("Onur",28,"Computer Engineer");
            Console.WriteLine("Author Name="+a.Name);
            Console.WriteLine("Total Article="+a.Article);
            Console.WriteLine("Branch Name="+a.Branch);

        }
    }
}
