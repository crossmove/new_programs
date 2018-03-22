using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class IntegerDuplicateCount
    {
        public static void DuplicateCount()
        {
            List<int> intList = new List<int> { 2, 3, 5, 5, 6, 1, 3, 5, 8,8};

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < intList.Count; i++)
            {
                if(dict.ContainsKey(intList[i]))
                {
                    dict[intList[i]]++;
                }
                else
                {
                    dict.Add(intList[i], 1);
                }
            }

            foreach (var item in dict)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine("key: "+ item.Key + " duplicate: "+ item.Value);
                }
            }
        }
    }
}
