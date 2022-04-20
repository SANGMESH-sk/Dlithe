using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            int n,r,sum=0,temp;
            Console.WriteLine("enter the number")
            n=int.Parse(Console.ReadLine());    
            temp=n;
            while (n > 0)
            {
                r=n%10;
                sum=(sum*10)+r;
                n=n/10;

            }
            if(temp==sum)
                Console.Writeline("no is palindrome");
            else
                Console.WriteLine("no is not palindrome")
            
        }
    }
}
