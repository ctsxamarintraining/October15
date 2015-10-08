using System;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = new int[10];
            intArray[0] = 1;
            intArray[9] = 1010;

            for (int index = 0; index < intArray.Length; index++)
            {
                //Console.WriteLine(intArray[index]);
            }

            foreach (int element in intArray) {
                Console.WriteLine(element);
            }

            string[] arr = new string[3] { "ABCd", "DD", "FF" };
            foreach (string myelement in arr) {
                Console.WriteLine(myelement);
            }

             string[] arrCopy = new string[3];

             Array.Copy(arr, arrCopy, 3);


            int[,,] twoDIntArray = new int[2,3,4];
            
            //jagged Array
            int[][] jaggedArr = new int[10][];
            //jaggedArr[0][0] = new int[] { 1, 2, 3 };

            
            Console.WriteLine("Array dimension is : " + twoDIntArray.Rank);


            //Console.WriteLine(intArray[99]);

            Person p1 = new Person();
            p1.FirstName = "ABCD";
            p1.LastName = "DEFG";
            p1.Age = 20;

            Person p2 = new Person();
            p2.FirstName = "dd";
            p2.LastName = "ff";
            p2.Age = 30;

            Person[] p = new Person[3];
            p[0] = p1;
            p[1] = p2;


            Console.WriteLine("----------Jagged array--------------");
            string[][] presidents = new string[3][] { 
                                                        new string[]{"Pranav Mukherjee", "Pratibha Patil", "A.P.J Abdul Kalam", "K.R. Narayanan"},
                                                        new string[]{"Mamnoon Hussain", "Asif Ali Zardari", "Pervez Musharraf"},
                                                        new string[]{"Barack Obama", "George W. Bush", "Bill Clinton", "George H. W. Bush", "Ronald Reagan"}
                                                   };

            string p12 = presidents[0][1];
            Console.WriteLine(" Indian Presidents: " + string.Join(",", presidents[0]));
            Console.WriteLine(" Pakistan Presidents: " + string.Join(",", presidents[1]));
            Console.WriteLine(" USA Presidents: " + string.Join(",", presidents[2]));

            Console.WriteLine(""); Console.WriteLine("");
            Console.ReadLine();

            Console.WriteLine(p[2]);

            Console.ReadLine();
        }
    }
}
