using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    // hashtable is a non-generic collection that stores key-value pairs
    //system.collection
    //key must be unique cannot be null
    //values can be null or dublicate

    internal class Hahtable
    {
       class table
        {
            public static void Main()
            {
                Hashtable hashtable = new Hashtable();
                hashtable.Add(1, "hello");
                hashtable.Add(2, "java");
                hashtable.Add(3, "python");
                hashtable.Add(4, "javascript");
                hashtable.Add(5, "c#");


                foreach(DictionaryEntry key in hashtable)
                {
                    Console.WriteLine("keys and values of hashtable key{0} Value {1}",key.Key,key.Value);
                }
                Console.ReadLine();
              
            }
        }


    }
}
