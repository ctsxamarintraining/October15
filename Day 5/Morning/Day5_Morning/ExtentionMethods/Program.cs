using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{i} is Even number : {i.IsEven()}");
            Console.WriteLine($"{i} is prime number : {i.IsPrime()}");
            Console.ReadLine();
        }
    }
}
