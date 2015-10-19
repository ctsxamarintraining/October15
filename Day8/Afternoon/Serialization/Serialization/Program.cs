using SerLib;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            Person personObj = new Person() { Age = 10, Firstname = "ABCD", LastName = "DEFG", PersonAddress = new SerLib.Address{ City = "Hyderabad", PinCode = "500084", State = "TELANGANA" } };

            using (Stream s = File.Create("c:\\users\\131377\\Desktop\\Person.xml")){            
                serializer.Serialize(s, personObj);            
            }

            
            
            //------------------------------------------------------------------------------------------------

            XmlSerializer serializer1 = new XmlSerializer(typeof(SampleGenericType<Car>));
            Car myCar = new Car { Color = "Red", Make = "Toyota", Model = "Etios" };
            SampleGenericType<Car> myGenericWrappedCar = new SampleGenericType<Car>(){ MyType = myCar};

            using (Stream s = File.Create("c:\\users\\131377\\Desktop\\car.xml"))
            {
                serializer1.Serialize(s, myGenericWrappedCar);
            }

            //-------------------------------------------------------------------------------------------------

            Car c = new Car { Color= "Red", Make="Toyota", Model="Etios" };
            BinaryFormatter bs = new BinaryFormatter();

            using (FileStream fs = File.OpenWrite("c:\\users\\131377\\Desktop\\Car.binary")){
                bs.Serialize(fs, c);
            }
 
            //--------------------------------------------------------------------------------------------------
            DataContractSerializer dcs = new DataContractSerializer(typeof(Person));
            using(FileStream fs = File.Create("c:\\users\\131377\\Desktop\\DCS-Person.xml")){
                dcs.WriteObject(fs, personObj);
            }

        }
    }
}
