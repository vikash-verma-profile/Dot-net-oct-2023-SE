using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class nullable3
    {
        public static void Main()
        {
            int ?a = null;
            Console.WriteLine(a);

            // dynamic vs var

            dynamic numberValue = 1;
            Console.WriteLine(numberValue.GetType());
            numberValue = "Vikash";
            Console.WriteLine(numberValue.GetType());
            Console.WriteLine(numberValue);

            var number = 1;
            //number = "Vikash";
            Console.WriteLine(number);
        }
    }
}
