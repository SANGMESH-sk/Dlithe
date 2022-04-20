using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MatrixAddition
    {
        public static void Main()
        {
             int i,j,n;
            int[,] arr1 = new int[20, 20];
            int[,] arr2 = new int[20, 20];
            int[,] arr3 = new int[20, 20];
            n = 3;
            Console.WriteLine("enter Elements in the first matrix:\n ");
            for (i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("enter Elements in the Second matrix:\n ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
           
            for (i = 0; i < n; i++)
            for (j = 0; j < n; j++)
            arr3[i, j] = arr1[i, j] + arr2[i, j];
            Console.WriteLine("\n Adding two matrices:\n");
            for(i = 0; i < n; i++)
            {
                Console.Write("\n");
                for(j = 0; j < n; j++)
                    Console .Write("{0}\t",arr3[i,j]);
            }
            Console.Write("\n\n");
            
            Console.ReadLine();
        }
    }
}
