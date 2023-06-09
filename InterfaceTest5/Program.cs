using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest5
{
    interface IFile
    {
        void ReadFile();
    }
    interface IBinaryFile
    {
        void OpenBinaryFile();
        void ReadFile();
    }

    class FileInfo : IFile, IBinaryFile
    {
        void IFile.ReadFile() 
        {
            Console.WriteLine("Reading Text File...");
        }

        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Opening Binary File...");
        }

        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Reading Binary File...");
        }

        public void Search(string text)
        {
            Console.WriteLine("Searching in File...");
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            IFile f1=new FileInfo();
            f1.ReadFile();

            IBinaryFile b1=new FileInfo();
            b1.ReadFile();
            b1.OpenBinaryFile();

            FileInfo fi=new FileInfo();

            fi.Search("text to be searched");


        }
    }
}
