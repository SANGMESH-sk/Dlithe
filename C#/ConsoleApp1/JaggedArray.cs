using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class JaggedArray
    {
        // jagged array :- is aarray of arrays such that members array can be diffrent sizes
        // jagged array can be mixed with multi dimensional array
        // user has to provide only no of rows 
        // if user provided no of column than it is not jagged array
        public static void Main()
        {
            // syntax
            // data_type[][] name of array = new data_type[rows][]
            int[][] jagged_arr = new int[4][]
            {
              new int[]  {1, 2, 3},
              new int[] {4, 5, 6},
              new int[] {6, 7, 8},
              new int[] {8, 9, 10}
            };
            // or
            int[][] jagged_arr1 = 
         {
              new int[]  {1, 2, 3},
              new int[] {4, 5, 6},
              new int[] {6, 7, 8},
              new int[] {8, 9, 10}
         };
            for(int i = 0; i < jagged_arr1.Length; i++)
            {
                Console.WriteLine("element index" + i + " ");
                for (int j=0; j<jagged_arr[i].Length; j++)
                {
                    Console.WriteLine(jagged_arr1[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            // output be like // element index [0] = 1,2,3
            // elememt index [1]= 4,5,6
            // elememt index [1]= 7,8,9
            // element index [2]= 8,9,10

        }
    }
}
