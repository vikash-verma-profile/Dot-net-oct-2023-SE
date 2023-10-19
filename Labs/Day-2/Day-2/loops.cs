using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class loops
    {
        public static void Main()
        {
            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine("Hi I a from for loop");
            }
            int counter = 0;
            while (counter > 0)
            {
                Console.WriteLine("Hi I a from while loop");
                counter++;
            }

            do
            {
                Console.WriteLine("Hi I a from do while loop");
                //counter++;
            } while (counter>0);
        }
    }
}
