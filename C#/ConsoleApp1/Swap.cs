using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Swap
    {
        public static void Main()
        {
            int a=10, b=20;
            Console.WriteLine("before swap a=" + a + "b=" + b);
            a =  a*b; // a=200
            b = a/b ; //200/20=10
            a = a / b; // 200/10=20

            Console.Write("after swap a="+b+" b="+a);
            Console.ReadLine();
        }
    }
}
