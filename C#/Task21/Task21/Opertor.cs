using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    internal class Opertor
    {
        public void Tern()
        {
            int x = 20, y = 30;
                    String result = x > y ? "x is bigger y" : "y is bigger than x";
            Console.WriteLine(result);
            // break statement

            for(int i=0; i<5; i++)
            {
                Console.WriteLine(i);

                break;
            }
            Console.WriteLine("break it use for braeking the statement");
            
            // continue statement
            for(int i=0; i<=5; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void Main()
        {
            Opertor ternary = new Opertor();
            ternary.Tern();
        }
    } 
}
