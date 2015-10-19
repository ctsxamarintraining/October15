using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DeSer
{
    [XmlRoot(ElementName = "Human")]
    public class Citizen
    {
        [XmlAttribute(AttributeName = "Identifier")]
        public string VoterId { get; set; }

        [XmlElement(ElementName = "GivenName")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Surname")]
        public string LastName{get;set;}

        [XmlElement(ElementName="AgeInYears")]
        public int Age{get;set;}
    }
}
