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

    internal class Hashtable
    {
       

        private static void Main()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "java");
            hashtable.Add(2, "java23");
        }
        

        private void Add(int v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
