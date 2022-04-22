using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    struct employee
    {
        int id;
        String s;
        public void getdetails()
        {
             id=Convert.ToInt32(Console.ReadLine());
             s=Console.ReadLine();
           
        }
        // constructor parameter
        public void display()
        {
            Console.WriteLine("id is: "+ id);
            Console.WriteLine("name is: "+ s);
            Console.ReadLine();
        }
        public employee(int a , string name)
        {
            id= a;
            s=name;
            Console.WriteLine("a value is : {0} and {1}",id , s);
        }
    }
    internal class Structure
    {
        public static void Main()
        {
            employee emp=new employee();
            employee emp2=new employee(10,"ravi");
            emp.getdetails();
            emp.display();
        }
    }
}
