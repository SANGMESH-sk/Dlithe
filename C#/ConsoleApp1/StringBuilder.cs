using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Stringuilder
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("hello", 30); // 30 is capacity it will expand memory dynamically
            Console.WriteLine(sb + "string builder"); //hello string builder
            // append method extending the value
            sb.Append("good");
            Console.WriteLine(sb); // hello good
            sb.AppendLine("world");
            sb.Append("hello");
            Console.WriteLine(sb);

            // inserting value with index 
            sb.Insert(5,"oooo");
            Console.WriteLine(sb);

            // remove method in string builder
            sb.Remove(5, 3);
            Console.WriteLine(sb); // removed ooo
          

            // replace method in String builder
            sb.Replace("hello", "very bad guy");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }

}
