using System;
using Test;

namespace Test1
{
	public static class ExtMethods
	{
		public static bool IsEven(this int val)
		{
			return val % 2 == 0;
		}

		public static string ToMyString(this DateTime v)
		{
			return v.ToString ("dd/MM/yy");
		}

		public static Emp ParseToEmp(this ServerEmp obj)
		{
			return new Emp{ID = obj.EmpID, Name = obj.EmpName};
		}

		public static string GetEmpInfo(this Emp  emp)
		{
			return string.Format("EmplyeeID is {0} and Name is {1}", emp.ID, emp.Name);
		}
	}
}

