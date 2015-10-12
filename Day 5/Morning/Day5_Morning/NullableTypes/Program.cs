using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            Console.WriteLine(i.HasValue);
            Console.WriteLine($"{i} is Even number : {i?.IsEven()}");
            Console.WriteLine($"{i} is prime number : {i?.IsPrime()}");

            i = 20;
            Console.WriteLine(i.HasValue);
            Console.WriteLine($"{i} is Even number : {i?.IsEven()}");
            Console.WriteLine($"{i} is prime number : {i?.IsPrime()}");
            Console.ReadLine();

           // int j = i;

        }
    }
}
