using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask27
{
    internal class Dispose : IDisposable
    {
        public void dispose()
        {
            Console.WriteLine("cache memory cleared");
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        public class disp
        {
            public disp(int a, int b)
            {
              
                int c = a + b;
                Console.WriteLine(c);
            }
            ~disp()
            {
                Console.WriteLine("addition operation disables");
            }
        }
        public class disposemain
        {
            public static void Main()
            {
                Console.WriteLine("enter the number  a value");
                int a=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the number  b value");
                int b=Convert.ToInt32(Console.ReadLine());  

                Dispose d=new Dispose();
                d.dispose();
                disp disp = new disp(a,b);

            }
        }
    }
}
