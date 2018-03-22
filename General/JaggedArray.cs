using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Jagged Array means array of array, 
namespace General
{
    class JaggedArray
    {
        public static void Method1()
        {
            int[][] jaggedArray = new int[2][]; // here we are mentioning array has 2 rows

            // Initialize the elements:

            jaggedArray[0] = new int[2] {9 ,6};
            jaggedArray[1] = new int[4] { 3, 6,2,4};

            Print(jaggedArray);
        }

        private static void Print(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                System.Console.Write("Element({0}): ", i + 1);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    System.Console.Write(jaggedArray[i][j] + "\t");
                }
                System.Console.WriteLine();
            }

        }
    }
}
