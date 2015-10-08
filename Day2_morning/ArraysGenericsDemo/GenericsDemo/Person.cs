using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }

    public class Employee : Person{
        public string EmployeeID { get; set; }
        public virtual void IncrementSalary() {
            //Console.WriteLine("Salary Incremented");
        }
    }

    public class Manager : Employee {
        public string[] ReporteeIDs {get; set;}
    }

    public class Contractor : Person {
        public Contractor(string parentCompanyID) { 
        }
        
        public string ContractorID { get; set; }

    }
      
}
