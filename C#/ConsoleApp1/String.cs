using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class String
    {
        // strings are used for storing Text
        public void Str()
        {
            string greet = "hello";
            string gree = "World";
            string c = greet + gree; // string concatination

            Console.WriteLine( "the length of the txt string is:    " +greet.Length); // finding length
            Console.WriteLine("the combination of the txt string is:    \n"+ string.Concat(greet,gree)); // used for combing
            Console.WriteLine("the combination of the txt string is:    " + c); // used for combing
            // String interpolution
            Console.WriteLine($"first name is {greet} lastname is {gree}");
            Console.WriteLine(c[1]); // e

            Console.WriteLine(c.IndexOf("e")); // 1
            Console.WriteLine("first name is \" {greet}\" lastname is {gree}");

            string x = "10";
            string y = "20";
            string z = x + y;
            Console.WriteLine(" string x+y : is :  =" + z); //1020

            
            string s = "123";
           // string builder
    
           
        }

    public static void Main()
    {
        String str=new String();    
        str.Str();
            Console.WriteLine("hello world");
            Console.ReadLine();
          
        }
    }
}
