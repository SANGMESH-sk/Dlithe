using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _1DArray
    {
   
        public static void Main()
        {
            int[] ar = new int[5] { 1, 2, 3, 4, 5 };
            int[] number = { 1, 2, 3, 4, 5, 6 };
            string[] str = { "java", "csharp", "python", "c" };

          
            foreach (string i in str)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("enter any number for sum of natural numbers");
           int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int sum = 0;
              for (int i = 0; i <= array.Length; i++)
            {
                sum =sum + i;
            }     
              Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
