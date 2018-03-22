using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class WaterCollectedBetweenTowers
    {
        static void WaterCollected()
        {
            int[] tower = { 7, 0, 0, 10 };
            int left_max = 0;
            int right_max = 0;

            int total = 0;

            for (int i = 1; i < tower.Length - 1; i++)
            {

                for (int j = i; j >= 0; j--)
                {
                    left_max = Math.Max(left_max, tower[j]);
                }

                for (int j = i; j <= tower.Length - 1; j++)
                {
                    right_max = Math.Max(right_max, tower[j]);
                }

                total = total + Math.Min(left_max, right_max) - tower[i];
            }
            Console.WriteLine(total);
        }
    }

}
