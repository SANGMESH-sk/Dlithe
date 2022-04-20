using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCsharp
{
    public class Avg
    {
        public void good()
        {
            int s1, s2, s3, total, avg1;

            Console.WriteLine("tnter the marks for first subject");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tnter the marks for second subject");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tnter the marks for third subject");
            s3 = Convert.ToInt32(Console.ReadLine());

             total = s1 + s2 + s3;
             avg1 = total / 3;
            Console.WriteLine("your total marks for  the 3subject is"+total);
            Console.WriteLine("your avg marks for  the 3subject is" + avg1);
            Console.WriteLine("hello c#" );
            Console.ReadLine();  // it use for reading the console

            // type casting:- it use for convering data type

        }

    }

}
