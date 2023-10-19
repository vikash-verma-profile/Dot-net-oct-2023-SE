using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class multi
    {
        public static void Main()
        {
            int[,] arr=new int[2,2];
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    arr[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("\t"+arr[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
