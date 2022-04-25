using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    internal class Errorhandling
    {
        class DivNumbers
        {
            int result;
            DivNumbers()
            {
                result = 0;
            }
            public void division(int num1, int num2)
            {
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Exception caught: ", e);
                }
                finally
                {
                    Console.WriteLine("Result: {0}", result);
                }
            }
            static void Main()
            {
                DivNumbers d = new DivNumbers();
                d.division(8,4);
                Console.ReadKey();
            }
        }

    }
}
