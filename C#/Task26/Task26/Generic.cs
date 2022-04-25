using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    internal class Generic
    {
        public class generic
        {

            public static void Swap<T>(ref T a, ref T b)
            {
                T temp;
                temp = a;
                a = b;
                b= temp;
            }
            public static void main()
            {
                int a = 40, b = 60;
                Console.WriteLine("before swap:{0},{1}",a,b);
                Swap(ref a, ref b);
                Console.WriteLine("after swap:{0},{1}", a, b);
                Console.ReadLine();
            }

        }

    }
}
