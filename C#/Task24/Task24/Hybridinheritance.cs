using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    internal class Hybridinheritance
    {
        class grandfather
        {
           public int c;
            public void land(int a)
            {
                Console.WriteLine("grand fathers land"+a);
            }
        }
        class father : grandfather
        {
            public void home()
            {
                Console.WriteLine("fathers home");
            }
        }
        class son : father
        {
            // constructor
            public void son1(int a,int b)
            {
                c = a + b;
                Console.WriteLine("Fathers car"+c);
            }
        }
        class Daughter : father
        {
            public void Daughter1(int a , int b)
            {
              c = a + b;
                Console.WriteLine("daughter property: "+c);
                Console.ReadLine();
            }
           
        }
        public class mainclass
        {
            public static void Main()
            {
                son s=new son();     // son can access grandfather + father
                s.son1(50,50);
                s.home();
                s.land(50);   
                Daughter d = new Daughter(); // daughter can access grandfather as well father
                d.land(50);
                d.home();
                d.Daughter1(25, 25);

            }
        }
    }
}
