using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest4
{
    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }

    class FileInfo : IFile
    {
        void IFile.ReadFile()
        {
            Console.WriteLine("Reading File...");
        }
        void IFile.WriteFile(string text)
        {
            Console.WriteLine("Writin File...");
        }

        public void Search(string text)
        {
            Console.WriteLine("Searching in file...");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();

            file1.ReadFile();
            file1.WriteFile("content");

            file2.Search("content");



        }
    }
}
