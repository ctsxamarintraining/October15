using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {

        //static void Main()
        //{
        //    string msg = "hello";
        //    string csharp = "C#"; 
        //    Console.WriteLine(string.Format("{0} {1}", msg , csharp));
        //    Console.ReadLine();
        //}
        
        #region SizeOf
        //static void Main(string[] args)
        //{
        //    int i = 10;

        //    i = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(string.Format("int MaxValue is {0},  MinValue is {1} and size is {2}", int.MaxValue, int.MinValue, sizeof(int)));
        //    Console.WriteLine(string.Format("long MaxValue is {0}, MinValue is {1} and size is {2}", long.MaxValue, long.MinValue, sizeof(long)));
        //    Console.WriteLine(string.Format("short MaxValue is {0}, MinValue is {1} and size is {2}", short.MaxValue, short.MinValue, sizeof(short)));
        //    Console.WriteLine(string.Format("float MaxValue is {0}, MinValue is {1} and size is {2}", float.MaxValue, float.MinValue, sizeof(float)));
        //    Console.WriteLine(string.Format("uint MaxValue is {0}, MinValue is {1} and size is {2}", uint.MaxValue, uint.MinValue, sizeof(uint)));
        //    Console.WriteLine(string.Format("uloong MaxValue is {0}, MinValue is {1} and size is {2}", ulong.MaxValue, ulong.MinValue, sizeof(ulong)));
        //    Console.WriteLine(string.Format("decimal MaxValue is {0}, MinValue is {1} and size is {2}", decimal.MaxValue, decimal.MinValue, sizeof(decimal)));
        //    Console.Read();
        //}
        #endregion


        #region Enum

        //enum Importance
        //{
        //    None=4,
        //    Trivial=6,
        //    Regular=8,
        //    Important=10,
        //    Critical=12
        //};

        //static void Main()
        //{
        //    // ... An enum local variable.
        //    Importance value = Importance.Critical;

        //    // ... Test against known Importance values.
        //    if (value == Importance.Trivial)
        //    {
        //        Console.WriteLine("Not true");
        //    }
        //    else if (value == Importance.Critical)
        //    {
        //        Console.WriteLine("True");
        //    }
        //    Console.Read();

        //}
#endregion


        #region convertes
        //static void Main()
        //{
        //    DateTime date = DateTime.Now;

        //    object o = 40;
        //    int i = 0;
        //    float j = i;//implicit

        //    int k = (int)o;//explicit
        //    int l = Convert.ToInt32(o); //explicit with null checking

        //    Console.WriteLine(date.ToString("dd/MM/yyyy hh:mm tt"));

        //    Console.WriteLine(k);
        //    Console.WriteLine(l);
        //    Console.ReadLine();
        //}
        #endregion


        #region Operators
        static void Main()
        {
            

            int i = 0;

            i = 10 * (20 + 30);

            Console.WriteLine(i);
            Console.ReadLine();

        }
        #endregion


        #region Struct
        //static void Main()
        //{
        //    Employee emp;
        //    emp.empID = 300;
        //    emp.Name = "test";
        //    emp.Print();
        //    Console.ReadLine();
        //}

    

        //struct Employee
        //{
        //   public int empID;
        //   public string Name;
        
        //    public void Print()
        //   {
        //       Console.WriteLine("Emp ID is {0} and Name is {1}", empID, Name);
        //   }
        //}
        #endregion

    }

}
