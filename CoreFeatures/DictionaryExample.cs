using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFeatures
{
    class Car { }
    class Bike { }

    class Example1
    {
        private Dictionary<Type, int> dictObj = new Dictionary<Type, int>();

        public void AddObjectsMethods() 
        {
            dictObj.Add(typeof(Car),1);
            dictObj.Add(typeof(Bike), 1);
            dictObj.Add(typeof(Car), 1);
            dictObj.Add(typeof(Bike), 1);

            foreach (KeyValuePair<Type,int> item in dictObj)
            {
                Console.Write(item.Key+"\t"+item.Value);
            }
        }
    }
}
