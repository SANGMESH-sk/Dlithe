using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CalculatorTask27
{
    public class nameexp : Exception
    {
        //Constructor
        public nameexp()
        {
            Console.WriteLine("Invalid Name");
        }
    }

    //Custom exception for invalid phone number
    public class numexp : Exception
    {
        //Constructor
        public numexp()
        {
            Console.WriteLine("Invalid phone number");

        }
    }

    public class regexpr
    {

        //Main method
        public static void Main()
        {
            string name;
            string num;
            bool test;
                //Try block
                try
                {
                    //Getting inputs from the user
                    Console.WriteLine("Enter your Name");
                    name = Console.ReadLine();


                    Console.WriteLine("Enter your Mobile Number");
                    num = Console.ReadLine();

                    //Passing name and num values to validate method
                    test = validate(name, num);
                }
            
                //Catch block 1 for catching invalid name 
                catch (nameexp)
                {
                    Console.WriteLine("enter your name correctly");
                }

                //Catch block 2 for catching invalid phone number
                catch (numexp)
                {
                    Console.WriteLine("number error enter your no once again");
                }

            }
        

        //Validate method
        public static bool validate(string name, string num)
        {
            //validation part for name
            var res = Regex.IsMatch(name, (@"^[a-zA-Z\.\s]+$"));

            //Checking for the result state
            if (res == false)
            {
                //Throws exeption if false
                throw new nameexp();
            }

            //validation part for Mobile number
            var res1 = Regex.IsMatch(num, (@"(^[0-9]{10}$)"));

            //Checking for the result state
            if (res1 == false)
            {
                //Throws exeption if false
                throw new numexp();
            }

            if (res == true && res1 == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}