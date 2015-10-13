using System;
using Test1;

namespace Test
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i = 10;
			Console.WriteLine (i.IsEven ());
			Console.WriteLine (DateTime.Now.ToString ("dd/MM/yyyy")); 
			Console.WriteLine (DateTime.Now.ToMyString ()); 

			ServerEmp sObj = new ServerEmp { EmpID = "405454", EmpName = "Raghu" };

			Emp obj = sObj.ParseToEmp ();

			Console.WriteLine (obj.GetEmpInfo());

		}
	}


	public class ServerEmp
	{
		public string EmpID{ set; get;}
		public string EmpName { set; get;}

	}

	public class Emp
	{
		public string ID{ set; get;}
		public string Name { set; get;}
	}
}
