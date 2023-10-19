using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class arrays5
    {
        public static void Main5()
        {
            //int[] testarr = { 1, 2, 3, 4, 5, 6, 7, };
            int[] testarr = new int[3];//7 variables of type int
            for (int i = 0; i < testarr.Length; i++) {
                testarr[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < testarr.Length; i++)
            {
                Console.WriteLine(testarr[i]);
            }
        }
    }
}
