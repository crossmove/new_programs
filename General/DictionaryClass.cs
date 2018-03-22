using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
//*Adding duplicate key, throws runtime exception.

//●	It returns error if we try to find a key which does not exist. but in hashtable it returns null
//●	It is faster than a Hashtable because there is no boxing and unboxing.
//●	Only public static members are thread safe.
//●	Dictionary is a generic type which means we can use it with any data type.

    public class DictionaryExample
    {
        public static void Method()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("key1", "pradeep");

            dic.Add("key2", "kumar");

            foreach (KeyValuePair<string, string> item in dic)
            {
                string key = item.Key;

                string value = item.Value;
            }

            dic.Remove("key1");

            //or
            string key2Value = dic["key2"];
            Console.WriteLine(key2Value);
        }
    }

}
