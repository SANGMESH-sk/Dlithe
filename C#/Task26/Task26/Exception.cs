using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    internal class Exception
    {
        /* Exception:- is a problem that arises during execution of the code 
         * its  having 4-types
          1. try : - identifies a block of code 
        2.catch:- catches an exception
        3.finally :- execute a given set of code
        4.throw :- a program throws an eception when a problem shows up*/
        class numbers
        {
            int result ;
            public void divnumber()
            {
                result=0;
            }
          
            public void devision(int num1, int num2)
            {
                
                try
                {
                    result=num1/num2;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("exception caught :{0}",ex);
                }
                finally
                {
                    Console.WriteLine("result {0}",result);
                }
            }
            // multiple catch
            public void multiple()
            {
                int[] number= { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int[] divisor = { 2, 0, 0, 5, 8 };

                for(int i=0; i<number.Length; i++)
                {
                    try
                    {
                        Console.WriteLine("Number: " + number[i]);  
                        Console.WriteLine("number: " +divisor[i]);
                        Console.WriteLine("quotient: " + number[i]/divisor[i]);
                    }
                    catch(DivideByZeroException ex)
                    {
                        Console.WriteLine("not possible to divide by zero {0}", ex);
                    }
                    catch(IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("index is out of range");
                    }
                    Console.ReadLine();
                }
            }
            
               


        }
        public static void Main()
        {
            numbers num=new numbers();
            num.divnumber();
            num.devision(25, 0);
            Console.ReadKey();
            num.multiple();

        }

    }
}
