using System;

namespace Day4.ExceptionsTraining
{
	class MainClass1
	{
		
		public static void Main (string[] args)
		{
			int num1 = 10;
			//Make it zero for devidebyzero exception
			int num2 = 2				;
			try{
				
				int result = num1 / num2;
				Employee employee = null; //new Employee("Kishore","Kolla");
				string name = employee.LName + ", " + employee.FName;
				Console.WriteLine("Emplyee name is: " + name);
				//Your logic which is causing exceptions
			}

			catch(DivideByZeroException zex) 
			{
				Console.WriteLine (zex.Message);
			}
			catch(NullReferenceException nullex) 
			{
				Console.WriteLine (nullex.Message);
			}
			catch(Exception ex) {
				Console.WriteLine ("Error occured in the program");
			}
			finally {
				//Here you need handle all unmanaged objects close or dispose
				Console.WriteLine("Finally block");
			}
				
			Console.WriteLine("End of the program");
			Console.ReadLine ();
		}
	}
}
