using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace SerializeTest2
{

    public class Program
    {

        public void SerializeNow()
        {
            ClassToSerialize c = new ClassToSerialize();
            File f = new File("temp.dat");
            Stream s = f.Open(FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(s, c);
            s.Close();
        }
        public void DeSerializeNow()
        {
            ClassToSerialize c = new ClassToSerialize();
            File f = new File("temp.dat");
            Stream s = f.Open(FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            c = (ClassToSerialize)bf.Deserialize(s);
            Console.WriteLine(c.name);
            s.Close();
        }

        public static void Main(string[] args)
        {
            Program st = new Program();
            st.SerializeNow();
            st.DeSerializeNow();
        }
    }
}
public class ClassToSerialize
{
    public int age = 100;
    public string name = "TOPRAK";
}

