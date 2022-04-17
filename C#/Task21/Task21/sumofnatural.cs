using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    internal class sumofnatural
    {
        public void numbers()
        {
            int i, j=0,sum=0;
            Console.WriteLine("enter the number to calculate sum");
            i = Convert.ToInt32(Console.ReadLine());
            while (j <= i)
            {
                sum = sum + j;
                j++;
            }

            Console.WriteLine("entered natural sum is" + sum);
            Console.ReadLine();

        }
        public static void Main()
        {
            sumofnatural N=new sumofnatural();
            N.numbers();
        }
    }
}
