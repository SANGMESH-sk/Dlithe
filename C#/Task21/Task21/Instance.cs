using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    internal class Instance
    {
        // static method or class method
        public static void run()
        {
            Console.WriteLine("im static  method");
        }
        // instatnce method
        public void engine()
        {
            Console.WriteLine("im non-static method");
            Console.ReadLine();
        }


        public static void Main()
        {
            // calling static method
            Instance.run();
            // caling instance method
            Instance instance=new Instance();
            instance.engine();
            Console.WriteLine();


        }
    }

}
