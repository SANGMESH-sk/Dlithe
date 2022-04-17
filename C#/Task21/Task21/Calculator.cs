using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    internal class Calculator
    {
        public void calc()
        {
            // addition
            Console.WriteLine("enter the first number ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number ");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the option you want to perform");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Substraction");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) devision");
            Console.WriteLine("Choice :");
            int choice=(int)Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("addition of two numbers : " + (a + b));
                    break;
                    case 2:
                    Console.WriteLine("substraction of two numbers: " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("substraction of two numbers: " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("substraction of two numbers: " + (a /b));
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;

            }
            Console.ReadLine();
            
        }
  
      public static void Main()
      {
        Calculator calculator = new Calculator();   
            calculator.calc();
      }


    }
}
