using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Floyd
    {
        public void Flyd()
        {


            int i, j, k = 1;
            for (i = 1; i < 4; i++)
            {
                for (j = 1; j < i+1; j++)
                {
                    Console.Write(k +" ");
                    k++;
                }
                Console.WriteLine(); // breaking line
              
            }
            Console.ReadLine();
        }

        public static void Main()
        {
            Floyd flyd = new Floyd();
            flyd.Flyd();

        }
    }
}
