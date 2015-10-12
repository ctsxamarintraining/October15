using System;
using Day4.ExceptionsTraining;

namespace Day4.UnhandledExceptions
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try{
				throw new IntrestRateCalcException();
				Employee employee = new Employee("Kishore","Kolla"); //new Employee("Kishore","Kolla");
			
				Console.WriteLine("Emplyee name is: " + employee.ToString());
				Console.WriteLine ("Hello World!");
			}
			catch(IntrestRateCalcException iex){
				Console.WriteLine ("Error occured : " + iex.Message);
			}
			catch(Exception ex){
				Console.WriteLine ("Error occured : " + ex.Message);
			}
				
		}
	}
}
