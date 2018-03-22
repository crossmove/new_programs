using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class BubbleSort
    {
        public static void Sort()
        {
            //https://stackoverflow.com/questions/2927578/listint-initialization-in-c-sharp-3-5

            List<int> numberList = new List<int>{11, 33, 4, 5, 17, 8, 90};

            int temp = 0; 

            for (int i = 0; i < numberList.Count -1; i++)
            {
                for (int j = i+1; j < numberList.Count; j++)
                {
                    if(numberList[i]>numberList[j])
                    {
                        temp = numberList[i];
                        numberList[i] = numberList[j];
                        numberList[j] = temp;
                    }
                }
            }

            foreach(int item in numberList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
