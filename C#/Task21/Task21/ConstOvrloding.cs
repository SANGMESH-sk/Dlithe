using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    internal class ConstOvrloding
    {
        /* is a special method which is ivoked automatically at the time of object creation 
         there are two types 
        constructor name is same as class name
        not same constructor  but we acheieve parameter constructor
        1. default constructor  == which has no argument is called default
        2.parameterized constructor == which has argument

         */
        public  ConstOvrloding()
        {
            Console.WriteLine("default constructor invoked");
        
        }
        int num;
        String name;

        //parameter constructor
        ConstOvrloding(String s,int n)
        {
            this.name = s;
            this.num = n;
        }
        ConstOvrloding(String s, int n,int m)
        {
            this.name = s;
            this.num = n;
            Console.WriteLine("accessing constructor overloading"+ s+n+m);
        }

        public static void Main()
        {
            ConstOvrloding c1=new ConstOvrloding("kgf",2);
            ConstOvrloding c2 = new ConstOvrloding("constructor", 3,5);

            Console.WriteLine("accesing parameterized cons"+ " "+c1.name +" "+ c1.num);
            Console.WriteLine("accesing parameterized cons" + " " + c2.name + " " + c2.num);

            Console.ReadLine();
          
        }
    }
}
