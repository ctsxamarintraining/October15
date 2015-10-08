using System;
using Demo;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        private static void CoVariance() {

            GenericStack<Employee> empGenericStack = new GenericStack<Employee>(5);

            IGenericStackCovariant<Person> personGenericStack = empGenericStack;
            Person p = personGenericStack.Pop();

            //Employee e = new Employee();
            //Person p = e;

            //IGenericStackPop<Person> personGenericStack = empGenericStack;
            //Person p = personGenericStack.Pop();
        }

        private static void Contravariance() {
            GenericStack<Employee> empGenericStack = new GenericStack<Employee>(5);

            IGenericStackContravariant<Manager> mGS = empGenericStack;
            mGS.Push(new Manager());

            //IGenericStackPush<Manager> mGenericStack = empGenericStack;
            //mGenericStack.Push(new Manager());
        
        }

        private static void Constraints()
        {
            Manager m = new Manager() { FirstName = "Manager-1" };
            Employee e = new Employee() { FirstName = "Employee-1" };

            EmployeeBonusStack<Employee> bonusStack = new EmployeeBonusStack<Employee>(5);
            bonusStack.Push(m);
            bonusStack.Push(e);

            bonusStack.IncrementSalary();
        }

        static void GenericExplanation() {

            
               IntegerStack iStack = new IntegerStack(5);

               iStack.Push(0);
               iStack.Push(100);
               iStack.Push(1000);

               int element = iStack.Pop();
               Console.WriteLine(element);

               element = iStack.Pop();
               Console.WriteLine(element);

               element = iStack.Pop();
               Console.WriteLine(element);

               GeneralPurposeStack gStack = new GeneralPurposeStack(5);

               gStack.Push("ABCD");
               gStack.Push("jj");        
               gStack.Push("kk");

               string element1 = (string) gStack.Pop();
               

            GenericStack<int> genericIntStack = new GenericStack<int>(5);

            genericIntStack.Push(0);
            genericIntStack.Push(1);

            int element22 = genericIntStack.Pop();
            Console.WriteLine(element);

            element = genericIntStack.Pop();
            Console.WriteLine(element);

            GenericStack<Person> pStack = new GenericStack<Person>(5);


            pStack.Push(new Person { FirstName = "ABCD" });
            pStack.Push(new Person { FirstName = "DEFG" });

            Person element122 = pStack.Pop();
            Console.WriteLine(element122.FirstName);

            element122 = pStack.Pop();
            Console.WriteLine(element122.FirstName);
        
        }
        
        

    }
}
