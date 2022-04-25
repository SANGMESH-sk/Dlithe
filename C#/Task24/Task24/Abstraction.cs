using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    internal class Abstraction
    {
        /* abstraction is the process of hiding certain details and showing only essential
         information to the user
        1. abstraction can can be acheived with either abstract classes or interfaces
        2.the abstract keyword used for classes and methods
        
         abstrct class: is a restricted class that cannot be used to create objects
         abstract method :- used only in an abstract class and it doesnt have a body
        the body provided by the derived class*/

        abstract class Current
        {
            public abstract void monthlybill ();

            public abstract void display();
           
        }
        class bill : Current
        {
            int totalcost,units=0,  charge=0, due=0, temp=0;
            int custid;
            string cname;
            public override void monthlybill()
            {
                Console.WriteLine("enter customer id");
                custid=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter customer name");
                cname=Convert.ToString(Console.ReadLine());
                Console.WriteLine("enter units" );
                units = Convert.ToInt32(Console.ReadLine());
                if (units < 100)
                {
                    charge = 1;
                    totalcost = units*charge+due;
                    Console.WriteLine("your bill is", totalcost);
                }
                else if (units < 300)
                {
                    totalcost = (int)(100 * 1.20) + (units - 300) * 3;
                    Console.WriteLine("your bill is", totalcost);
                }
                else if (units > 300)
                {
                    totalcost = (int)(100 * 1.20 + 200 * 2) + (units - 300) * 3;
                    Console.WriteLine("your bill is", totalcost);

                }
              
               
            }
            public override void display()
            {
                Console.WriteLine("customer id is {0}", custid);
                Console.WriteLine("customer id is {0}", units);
                Console.ReadLine();
            }
            
        }
        public static void Main()
        {
            bill Animal=new bill();
            Animal.display();
            Animal.monthlybill();

        }
    }
}
