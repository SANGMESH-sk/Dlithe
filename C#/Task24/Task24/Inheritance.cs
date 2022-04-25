using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    internal class Inheritance
    {
       public class vehicle
        {
           public string brand = "ford";
            public void small()
            {
                Console.WriteLine("this is a car");
                Console.ReadLine();
            }
        }
         class Cars : vehicle
        {
            public string modelname = "ford mustang";
        }

        class program
        {
            public static void Main()
            {
                Cars mycar=new Cars();
                mycar.small();
                Console.WriteLine(mycar.brand+ mycar.modelname);
            }
        }
    }
}
