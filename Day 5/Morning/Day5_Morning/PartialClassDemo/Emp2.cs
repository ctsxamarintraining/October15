using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassDemo
{
    public partial class Emp
    {
        public void Print()
        {
            Console.WriteLine("From Emp2 File");
        }

        public void Wait()
        {
            Console.Read();
        }
    }
}
