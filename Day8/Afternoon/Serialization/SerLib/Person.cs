using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerLib
{
    [XmlRoot(ElementName="Human")]
    public class Person
    {
        private String PanNumber { get; set; }

        public Person() {
            this.Id = Guid.NewGuid().ToString();
            //this.MySelf = this;
        }

        public Person MySelf { get; set; }

        [XmlAttribute(AttributeName = "Identifier")]        
        public String Id { get; set; }

        [XmlElement(ElementName = "AgeInYears")]
        public int Age
        {
            get;
            set;
        }
        
        [XmlElement(ElementName = "GivenName")]
        public string Firstname
        {
            get;
            set;
        }

        [XmlElement(ElementName = "Surname")]
        public string LastName
        {
            get;
            set;
        }
              

        [OnSerialized]
        public void Onserialized( StreamingContext sc) {
            int i = 0;
        }

        [OnSerializing]
        public void Onserializing( StreamingContext sc)
        {
            int i = 0;
        }

        public Address PersonAddress {get;set;}
    }


    public class Address {
        
        public string City { get; set; }
        public string State {get;set;}
        public string PinCode{get;set;}
    }

}
