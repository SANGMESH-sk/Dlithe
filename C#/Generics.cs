using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task28
{
   
        //Generic is a class which allows the user to
        //define classes and methods with the placeholder.
        public class Gencalc<T>
        {
            //Creating generic method Addition
            public T Addition(T no1, T no2)
            {
                dynamic a = no1;
                dynamic b = no2;
                return a + b;
            }

            //Generic method Subtraction
            public T Subtraction(T no1, T no2)
            {
            dynamic a = no1;
            dynamic b = no2;
            return a - b;
            }

            //Generic method multiplication
            public T Multiplication(T no1, T no2)
            {
            dynamic a = no1;
            dynamic b = no2;
            return a * b;
            }

            //Generic method Division
            public T Division(T no1, T no2)
            {
            dynamic a = no1;
            dynamic b = no2;
            return a / b;
            }
        }
        public class calculator
        {
            //Main method
            public static void Main()
            {
                //Variable declaration
                int choice;
                char m = 'y';
                int a = 0, b = 0;
                double d = 0, e = 0;

                //Creating instance for generic class 
                Gencalc<int> cal = new Gencalc<int>();
                Gencalc<double> cal2 = new Gencalc<double>();
                Console.WriteLine("Simple calculator app using Generics\n");
                    Console.WriteLine("Choose your method");
                    Console.WriteLine("\n 1:ADDITION\n 2:SUBTRACTION\n 3:MULTIPLICATION\n 4:DIVISION\n ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    //Switch case
                    switch (choice)

                    {
                        //Addition operation
                        case 1:
                            Console.Write("Enter the value of a    : ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nEnter the value of b : ");
                            b = Convert.ToInt32(Console.ReadLine());
                            int sum = cal.Addition(a, b);
                            Console.WriteLine("Addition of a and b is :{0}", sum);
                            Console.Write("Continue to calculation [Y/N] : ");
                            m = Convert.ToChar(Console.ReadLine());
                            break;

                        //Subtraction operation 
                        case 2:
                            Console.Write("Enter the value of a  : ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nEnter the value of b : ");
                            b = Convert.ToInt32(Console.ReadLine());
                            int val = cal.Subtraction(a, b);
                            Console.WriteLine("\nSubtraction of a and b is:{0}", val);
                            Console.Write("Continue to calculation [Y/N] : ");
                            m = Convert.ToChar(Console.ReadLine());
                            break;

                        //Multiplication operation
                        case 3:
                            Console.Write("Enter the value of a : ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nEnter the value of b : ");
                            b = Convert.ToInt32(Console.ReadLine());
                            int mux = cal.Multiplication(a, b);
                            Console.WriteLine("\nMultiplication of a and b is:{0}", mux);
                            Console.Write("Continue to calculation [Y/N] : ");
                            m = Convert.ToChar(Console.ReadLine());
                            break;

                        // Division operation
                        case 4:
                            Console.Write("Enter the value of a  : ");
                            d = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter the value of b : ");
                            e = Convert.ToDouble(Console.ReadLine());
                            double div = cal2.Division(d, e);
                            Console.WriteLine("\nDivision of a and b is :{0}", div);
                            Console.Write("Continue to calculation [Y/N] : ");
                            m = Convert.ToChar(Console.ReadLine());
                            break;


                        //Default state
                        default:
                            Console.WriteLine("Invalid option");
                            Console.Write("Try Again? [Y/N] : ");
                            m = Convert.ToChar(Console.ReadLine());
                            break;
                    }
                
            }
        }
    
}