using System;
using Demo;

namespace GenericsDemo
{
    public class EmployeeBonusStack<T>: GenericStack<T> where T: Employee
    {
        public EmployeeBonusStack(int size) : base(size) { }
 
        public void IncrementSalary() {
            foreach (T emp in this.stackArr) {
                if (emp == default(T))
                    continue;
                emp.IncrementSalary();
                Console.WriteLine("{0}'s salary was incremented", emp.FirstName);
            }
        }
    }
}
