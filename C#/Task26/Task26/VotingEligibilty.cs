using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    class MyExeption : ApplicationException
    {
        public void exception()
        {
            Console.WriteLine("your age is less than 18 your not eleigible");
            Console.ReadLine();
        }
        public void mydivide()
        {
            Console.WriteLine("An exception occured");
        }
    }
    class testMyexception
    {
        public static void Main()
        {
            int age;
            string name;
            Console.WriteLine("enter your name");
            name=Console.ReadLine();
            Console.WriteLine("enter your age");
            age =Convert.ToInt32(Console.ReadLine());

            try
            {
                if (age < 18)
                {
                    throw new MyExeption();
                }
                else if (age > 18)
                {
                    Console.WriteLine("your eleigible for voting");
                    Console.ReadLine();
                }
            }
            catch (MyExeption e)
            {
                e.exception();
            }

        }
    }
   
}
