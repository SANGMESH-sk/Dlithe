using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask27
{
    internal class passByvalueandreference
    {

        public class reference
        {
            public static void refer(ref int referenceparameter)
            {
                Console.WriteLine("reference value it is use for passing :" + referenceparameter);
            }
            public void Value(int m)
            {
                Console.WriteLine("the value we are passing through value" + m);
            }
        }
        public static void Addition(out int oname)
        {
            oname = 40;
            Console.WriteLine("accessing out keyword uses for passing value with reference" + oname);
        }
        public static void changevalue(int x)
        {
            x = 300;
            Console.WriteLine(x);
        }
        public static void Main()
        {
            reference reference = new reference();
            int arg;
            arg = 5;
            reference.refer(ref arg); // the value is passing through reference
            reference.Value(arg); // passing through value;

            // out keyword
            // the out keyword in c# which is used for the passing the arguments to methods asa reference type
            // it is similar to refernce keyword
            // ex:-
            int oname;
            Addition(out oname);
            // value type means bool,byte,char,int,string,float
            // value type variable int i=100 it is passing method int x
            int j = 100;
            Console.WriteLine(j);
            changevalue(j);
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
