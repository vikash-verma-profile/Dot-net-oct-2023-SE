using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class jaggedarray2
    {
        public static void Main()
        {
            int[][] jagged_array = new int[3][];
            jagged_array[0] = new int[] { 1, 2 };
            jagged_array[1] = new int[] { 11, 12, 14, 787 };
            jagged_array[2] = new int[] { 1345, 2, 3, 90, 78, 78 };

            for (int i = 0; i < jagged_array.Length; i++)
            {
                for (int k = 0; k < jagged_array[i].Length; k++)
                {
                    Console.Write("{0} ,", jagged_array[i][k]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("{0} , {1} ,",12,"Vikash");
        }
    }
}
