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
        public interface IInterface1
        {
          void area(); //does not have a body
          
        }
        public interface IInterface2
        {
             void perimeter(); // doesnt have body

        }
        public class Triangle : IInterface1 , IInterface2
        {
            void  IInterface1.area()
            {
                int a=0;
                Console.WriteLine(" we are finding area of triangle");
                Console.WriteLine("enter the base value of triangle");
                int b=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the height of the triangle");
                int h=Convert.ToInt32(Console.ReadLine());
                double result = 0.5* b * h;
                Console.WriteLine("Area of Triangle is {0}", result);
                
            }
            void IInterface2.perimeter()
            {
                Console.WriteLine("Now we are Finding Perimeter");
                Console.WriteLine("enter the side value of triangle");
                int a = Convert.ToInt32(Console.ReadLine());
             
                Console.WriteLine("enter the base value of triangle");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the height of the triangle");
                int h = Convert.ToInt32(Console.ReadLine());
                double result = a+ b + h;
                Console.WriteLine("perimeter of Triangle is {0}", result);
                Console.ReadLine();

            }
        }
        class program
        {
            public static void Main()
            {
               IInterface1 interface1 = new Triangle();
                interface1 .area();
                IInterface2 interface2 = new Triangle();

                interface2.perimeter();

            }

        }
       
    }
}
