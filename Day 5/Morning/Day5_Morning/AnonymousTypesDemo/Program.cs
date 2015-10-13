using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousTypesDemo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<Dept> DepartMents = new List<Dept>
			{
				new Dept {DeptId=1, DeptName="Accounts" },
				new Dept {DeptId=2, DeptName="HR" },
				new Dept {DeptId=3, DeptName="Sales" },
			};

			List<Employee> Employees = new List<Employee>
			{
				new Employee {EmployeeId=20001, DeptId=1, EmployeeName="Emp1" },
				new Employee {EmployeeId=20002, DeptId=2, EmployeeName="Emp2" },
				new Employee {EmployeeId=20003, DeptId=3, EmployeeName="Emp3" },
				new Employee {EmployeeId=20004, DeptId=1, EmployeeName="Emp4" },
				new Employee {EmployeeId=20005, DeptId=2, EmployeeName="Emp5" },
				new Employee {EmployeeId=20006, DeptId=3, EmployeeName="Emp6" },
				new Employee {EmployeeId=20007, DeptId=3, EmployeeName="Emp7" },
				new Employee {EmployeeId=20008, DeptId=2, EmployeeName="Emp8" },
				new Employee {EmployeeId=20009, DeptId=1, EmployeeName="Emp9" },
				new Employee {EmployeeId=20010, DeptId=2, EmployeeName="Emp10" },
			};

			var emps = from emp in Employees
				join dep in DepartMents on emp.DeptId equals dep.DeptId
				select new { EmpID = emp.EmployeeId, EmpName = emp.EmployeeName, DepartMentName = dep.DeptName };

			foreach (var row in emps)				
				Console.WriteLine($"Employee Name is {row.EmpName}, Employee Ids is {row.EmpID} and Department is {row.DepartMentName}");

		}
	}


	class Employee
	{
		public string EmployeeName;
		public int EmployeeId;
		public int DeptId;
	}

	class Dept
	{
		public int DeptId;
		public string DeptName;
	}
}
