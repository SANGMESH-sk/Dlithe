using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bitwise
    {
        public static void Main()
        {
           //1. And operator
            int a = 42;    /*  42=  101010  43= 101011 ==  101011 ==43*/
            int b = 43;
            int c = a & b;
            Console.WriteLine(c); // 42
          
            int a1 = 42;    /*  42=  101010  44= 101101 ==  101000 ==40*/
            int b1 = 44;
            int c1 = a1 & b1;
            Console.WriteLine(c1); // 40
       

            // 2. OR Operator (|) 
            int c2 = a | b;            // it will add the value a+b=101010
            Console.WriteLine(  c2); // 43

            //3.XOR OPERATOR // if the corrosponding bits are same then the result is 0 if not then 1
            int c3 = a ^ b;               //                101010
            Console.WriteLine("xor operator" + c3);     //  101011
            Console.WriteLine("xor operator");          //  000001 == output is 1

            // 4.Left Shift
            int number = 42;
            Console.WriteLine( number<<1); //  42*2;
            Console.WriteLine( number << 2); // 42*4
            Console.WriteLine( number << 4); // 42*16

            // 5.Right Shift
            Console.WriteLine(number >> 1); //  21
            Console.WriteLine(number >> 2); // 10
            Console.WriteLine(number >> 4); // 2
            Console.ReadLine(); 

        }
    }

}
