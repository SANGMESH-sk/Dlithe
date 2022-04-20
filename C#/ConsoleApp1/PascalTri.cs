using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PascalTri
    {
        public void Tringle()
        {
            Console.WriteLine("enter an numberb to see the  pascal Triangle");
           // int number=Convert.ToInt32(Console.ReadLine());
            int i, j, k, blank, val=1 ;
            Console.Write("\n\n");
            for(i = 0; i < 5; i++)
            {
                for(blank = 1; blank < 5-i; blank++)
                    Console.Write(" ");
                    for(j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0) 
                        val = 1;
                        else
                            val = val * (i - j + 1) / j;
                        Console.Write("{0} ",val);
                    }
                    Console.WriteLine("\n");
                
            }
            Console.ReadLine() ;

        }

        public static void Main()
        {
            PascalTri Tri = new PascalTri();
            Tri.Tringle();
        }
    }
}
