using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Debuggibg
    {
        public static void Main()
        {
            int i,j;
            int[,] arr1=new int[3,3];
            int[,] arr2 = new int[3, 3];
            Console.Write("\n\n read  a 2d array of size 3X3 and print the matrix:\n");


            Console.Write("input elemets in the first matrix");
            for (i = 0; i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0}]:",i,j);
                    arr1[i,j]=Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.Write("input elemets in the second matrix");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0}]:", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.Write("\n the matrix is:\n");
            for(i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
            Console.ReadLine();
        }
    }
}
