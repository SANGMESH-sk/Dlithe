using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    internal class eleBillAbstraction
    {
        // abstraction it use for hidig certain details and showing only essential data
        // abstraction can be acheive either by using abstract class or interfaces
       public abstract class Calculator
        {
            public abstract void Calc();
            public abstract void bill();

        }
        public class Abill : Calculator
        {
            public double bil;

            public override void Calc()
            {
                
            Console.WriteLine("Enter Customer Id");
                int custid=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter Customer Name");
                string custname=(Console.ReadLine());
                Console.WriteLine("enter Units USED");
                int units=Convert.ToInt32(Console.ReadLine());

                if (units < 100)
                {
                    bil = units * 1.20;
                }
                else if(units <300)
                {
                    bil = 100 * 1.20 + (units - 100) * 2;
                }
                else if (units > 300)
                {
                    bil = 100 * 1.20 + 2002 + (units - 300) * 3;
                }

            }
            public override void bill()
            {
                Console.WriteLine("your bill is"+bil);
            }
        }
        public class total
        {
            public static void Main()
            {
               Abill a=new Abill();
                a.Calc();
                a.bill();
                Console.ReadLine();
            }
        }
    }
}
