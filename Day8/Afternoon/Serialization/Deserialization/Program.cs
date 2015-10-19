using DeSer;
using DeSerLib;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer ds = new XmlSerializer(typeof(Citizen));
            Citizen citizen;
            using (FileStream fs = File.OpenRead("c:\\users\\131377\\Desktop\\Person.xml"))
            {
              citizen =(Citizen) ds.Deserialize(fs);                
            }


            Car c = null;
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = File.OpenRead("c:\\users\\131377\\Desktop\\car.binary")) {
               c = (Car)bf.Deserialize(fs);
            }

            Console.ReadLine();
        }
    }
}
