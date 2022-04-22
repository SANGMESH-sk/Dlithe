using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    internal class Oops
    {
        private String studentname;
        private String studentAge;   
        public string  oops1
        {
            // encpsualation
            get {
                return studentname;
            }
            set {
                studentname = value;
            }
        }
        class vehicle
        {
            public string brand = "ford";
            public void honk()
            {
                Console.WriteLine("mustang");
            }
        }
        class car : vehicle
        {
            public string modelname = "mustang";
        }
        interface Ianimal
        {
            void animalsound();
        }

        public static void Main()
        {
            // objects
            Oops oops= new Oops();
            oops.oops1 = "divya";
            Console.WriteLine(oops.oops1);
            Console.ReadLine();

            car car = new car();
            car.honk();
            Console.WriteLine(car.brand+""+car.modelname);
            Console.ReadLine();
        }
    }
}
