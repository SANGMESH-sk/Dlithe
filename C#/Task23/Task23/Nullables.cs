using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    internal class Nullables
    {
        public static void Main()
        {
            // ? it use for declaring null values
            int num = 100;
            int? num2 = null;
            
            Nullable<int> num3 = null;
            Console.WriteLine(num); 
            Console.WriteLine(num2);
            Console.ReadLine();

            int? i = null;
            double? num4 = null;

            string  item6 = null;

            string item5 = "hello";

            float ? item4= null;




            // null coallascing
            int? a = null;
            int? b = 10;
            int? c;
            c = a ?? b;  // it will check the value left and right and retrive
            Console.WriteLine(c);
            c = a ?? 200;
            Console.WriteLine(c);
           

            string item1 = null;

            string item2 = "hello";
            string item3;
            item3 = item1 ?? item2;
            Console.WriteLine(item3);
            Console.ReadLine();

        }
    }
}
