using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    //https://www.dotnetperls.com/hashtable
    //It returns null if we try to find a key which does not exist.
    //It is slower than dictionary because it requires boxing and unboxing.
    //All the members in a Hashtable are thread safe,
    //Hashtable is not a generic type

    class HashTableClass
    {
        public static void Method()
        {
            //Adding elements and retreving elements into Hashtable
            Hashtable hash = new Hashtable();
            hash.Add("2", 'a');
            hash.Add(5, 3);
            hash.Add('C', "pradeep");

            hash.Add("1", "b");
            hash.Add("1", "b");     //imp// This line throws exception: "Item has already been added" 
           

            object value = hash["2"];   //value = 'a'
            object value1 = hash['2'];  //as '2' not exist value is value = Null

            //Another way of adding elements into Hashtable
            //Example2:
            Hashtable hashtable = new Hashtable();
            hashtable['i'] = 10;
            hashtable["Add"] = "Bangalore";
            hashtable[20] = 'X';

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
            }

        }
    }
}
