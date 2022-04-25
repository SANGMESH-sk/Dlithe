using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
      delegate int NumberChanger(int s);
    internal class MultiCastDeligate
    {
        // deligates is a reference type variable that holds the refernce to a method 
        // the refence can be changed at runtime
        // declaration of delagate
        // uses:- delegates allows method to be passed as an parameter
        // deleigates used to define callback methods
        // multiple method can be can be called on a single event
      class Testdelegate
        {
            static int num = 10;
            public static int Addnum(int p)
            {
                num += p;
                return num; 
            }
            public static int multinum(int q)
            {
                num *= q;
                return num;

            }
            public static int getNum()
            {
                return num;
            }

            public static void Main()
            {
                Testdelegate testdelegate = new Testdelegate();
                NumberChanger deligate = new NumberChanger(Addnum);
                NumberChanger deligate2 = new NumberChanger(multinum);
                NumberChanger deligate3;
                
                deligate(5);
                Console.WriteLine("value of Num:{0}", getNum());
                deligate2(15);
                Console.WriteLine("value of Num:{0}", getNum()); 
                
                // multicast deligate
                deligate3 = deligate;
                deligate3 += deligate2;
                // calling multicasting;
                deligate3(3);
                Console.WriteLine("value of multicasting deleigate is : {0}", getNum());
                Console.ReadLine();
            }
        }
    }
}
