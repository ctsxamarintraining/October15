using System;

namespace Day4.ExceptionsTraining
{
	public class Employee:Object
	{
		public Employee()
		{
			Id = Guid.NewGuid ().ToString();
		}
		public Employee(string fName,string lName):this()
		{
			FName = fName;
			LName = lName;
		}
		public string FName {get;set;}
		public string LName {get;set;}
		public string Id { get; set;}
	
		public override string ToString ()
		{
			if (string.IsNullOrWhiteSpace (FName))
				throw new ApplicationException ("First name is mandatory.");
			Organisation organisation = new Organisation ("");

			return string.Format ("[Employee: FName={0}, LName={1} belonogs to department {3}  with registered id Id={2}]", FName, LName, Id,organisation.Department);
		}


		public class Organisation{

			private string _department;

			public string Department {
				get { 
					try
					{
					if (string.IsNullOrWhiteSpace(_department)) {
						throw new ApplicationException ("Department is mandatory.");
					}
					}
					catch(Exception ex) {
						Console.WriteLine ("error occured due to depratment is not initialised in orgnisation class");
						throw ex;
					}
					return _department; 
				
				}
				set { _department = value;}
			}

			public Organisation(string department)
			{
				Department = department;
			}

		
		}

	}
}

