using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    internal class UserDisplay
    {
        public void UD()
        {
            Console.WriteLine("enter your name to show");
            String s = Console.ReadLine();
            Console.WriteLine("enter your last name to show");
            String s1= Console.ReadLine();
            Console.WriteLine("enter your age");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your entered name is"+s +" "+ "lastname"+ " "+ s1 + " " + "age" + " " +age +" "+  "salary" +" "+salary);
            Console.ReadLine();
        }
        public static void Main()
        {
            UserDisplay ud=new UserDisplay();
            ud.UD();
        }
    }
}
