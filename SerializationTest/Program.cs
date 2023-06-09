using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTest
{
    [Serializable]
    class Tutorial
    {
        public int ID;
        public string Name;


        static void Main(string[] args)
        {
            //Intialize object
            Tutorial obj = new Tutorial();
            obj.ID = 1;
            obj.Name = "Test";
            Json.Conver


            //Create stream file
            IFormatter formatter=new BinaryFormatter();
            Stream stream=new FileStream (@"E:\ExampleNew.txt",FileMode.Create,FileAccess.Write);

            //Serialized object
            formatter.Serialize (stream, obj);
            stream.Close();

            //Deserialized object
            stream=new FileStream(@"E:\ExampleNew.txt", FileMode.Create, FileAccess.Write);
            Tutorial objnew =(Tutorial) formatter.Deserialize (stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);

            Console.ReadLine();
        }
    }
}
