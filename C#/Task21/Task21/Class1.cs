using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    public class Class1
    {
        public void totalavg()
        {
            int s1, s2, s3, total, avg,s4;
            Console.WriteLine("enter the first subject marks");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd subject marks");
            s2 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("enter 3rd subject marks");
            s3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("if u want to see average of your marks enter 1");
            total = Convert.ToInt32(Console.ReadLine());
            if(total == 1)
            {
                s4 = s1 + s2 + s3;
                Console.WriteLine("your total marks is" + s4);

            }
            else
            {
                Console.WriteLine("please enter 1 for seeing your total marks");
            }
            Console.WriteLine("please enter the 2 for average marks ");
            avg = Convert.ToInt32(Console.ReadLine());
            if (avg == 2)
            {
              int  s5 =( s1 + s2 + s3)/3;
                Console.WriteLine("your avg marks is" + s5);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("please enter 2 for seeing your avg marks");
            }


        }
        public static void Main()
        {
            Class1 clas = new Class1();
            clas.totalavg();
        }
    }
}
