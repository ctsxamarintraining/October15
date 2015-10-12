using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.Show();
            emp.Print();
            emp.Wait();

        }
    }
}
