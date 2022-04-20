using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arrays
    {
        // arrays in c#
        public void array()
        {
            string[] arr = { "volvo", "ford", "tesla" };
            int[] ar= {5,6,1,2,3};
            // finding index of an array
            Console.WriteLine(Array.IndexOf(arr,"volvo"));// 0 
            // max,min,length,sum
            Console.WriteLine(ar.Max());// 6
            Console.WriteLine(ar.Min());// 5
            Console.WriteLine(ar.Length); //
            Console.WriteLine(ar.Sum()); //

            Console.WriteLine(arr[0]);  // volvo
            Array.Sort(ar); // it will in order
            foreach(int i in ar)
            {
                Console.WriteLine(i); // 1,2,3
              
            }
            

            // declarattion of multi dimensional array
            int[,] a = 
            {
                {0,1,2,3 },
                {1,2,3,4},
                {3,4,5,6}
            };
            for(int i = 0; i < 5; i++)
            {
               for(int j=0; j<2; j++)
                {
                    Console.WriteLine(i);

                }
            }
            Console.WriteLine(" 2d array");
            Console.ReadLine();
        }


        public static void Main()
        {
            Arrays ar = new Arrays();
            ar.array();
        }
    }
}
