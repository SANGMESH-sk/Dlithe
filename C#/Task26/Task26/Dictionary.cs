using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    internal class Dictionary
    {
        // is a generic collection that stores keys and values pairs in particular order
        // it comes under system.Collections.generic
        // key must be unique cannot be null

        public static void Main()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            // adding key value pairs in the dictionary using add method
            dic.Add(1, "java");
            dic.Add(2, "python");
            dic.Add(3, "js");
            dic.Add(4, "c#");
            dic.Add(5, "c++");
          
            foreach(KeyValuePair<int,string> kvp in dic)
            {
                Console.WriteLine("key:{0},Value{1}",kvp.Key, kvp.Value);
            }
            Dictionary<string, string> dic2 = new Dictionary<string, string>();
            dic2.Add("UK", "london");
            dic2.Add("usa", "chicago");
            dic2.Add("asia", "india");
            foreach (KeyValuePair<string,string> key in dic2)
            {
                Console.WriteLine("key:{0},Value:{1}",key.Key,key.Value);
            }

            Console.ReadLine();
        }
    }
}
