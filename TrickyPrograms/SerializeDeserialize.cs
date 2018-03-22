using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class SerializeDeserialize
    {
        static string filePath = @"c:\abc.txt";
        public static void Serialize()
        {
            Emp emp = new Emp() { ID = 10, Name = "pradeep" };

            //Stream:  Abstract class. Provides a generic view of a sequence of bytes
            using(Stream stream = File.Open(filePath,FileMode.Create))
            {
                BinaryFormatter binaryForm = new BinaryFormatter();
                binaryForm.Serialize(stream, emp);
            }
        }

        public static void DeSerialize()
        {
            using(Stream stream = File.OpenRead(filePath))
            {
            BinaryFormatter binaryForm = new BinaryFormatter();
            Emp obj = (Emp)binaryForm.Deserialize(stream);
            Console.WriteLine(obj.ID+" "+obj.Name);
            }
            
        }
    }
    [Serializable]
    public class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
