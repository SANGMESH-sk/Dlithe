using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    internal class ParamArray
    {
        public static void paramsarray(params int[] a)
        {
            int total=0;
          for(int i=0; i<a.Length; i++)
            {
                total=total+a[i];
            }
          Console.WriteLine("sum of natural no: "+total);
            Console.ReadLine();
        }
           
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter the size of the array");
            n = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[n];

            Console.WriteLine("Enter the Values");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            paramsarray(num);
            Console.Write("\n\n");
        }
    }
}
