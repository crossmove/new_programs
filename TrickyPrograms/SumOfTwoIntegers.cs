using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class SumOfTwoIntegers
    {
        int[] list = { 1, 2, 3, 4, 5, 6, 6, 5, 2, 5}; 
        Hashtable   hashtable = new Hashtable();

        int firstNumPosition = 0;
        int secondNumPosition = 0;

        public void SumOf(int targetNum)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (hashtable.ContainsKey(list[i]))
                {
                    firstNumPosition = (int)hashtable[list[i]];
                    secondNumPosition = i;
                    Console.WriteLine(list[firstNumPosition] + "," + list[secondNumPosition]);
                }
                else
                {
                    if (!hashtable.ContainsKey(targetNum - list[i])) //this line is to handle  some expection
                    {
                        hashtable.Add(targetNum - list[i], i);
                    }
                }
            }
        }
    }
}
