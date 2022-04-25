using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    internal class interfaces
    {
        //interfsces:-an interface is a completly abstractClass which can only contain Abstract Methods 
        // and properties(with empty bodies 
        interface IInterface
        {
           void mymethod(int a); //does not have a body
          
        }
        class pig : IInterface
        {
            public void mymethod(int a)
            {
                int b = a;
                Console.WriteLine("hello interfaces",b);
                Console.ReadLine();
            }
        }
        public static void Main()
        {

            pig i=new pig();
            i.mymethod(8);
          
        }
    }
}
