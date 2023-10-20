using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class conversion4
    {
        public static void Main4()
        {
            //int a = Convert.ToInt32("123");
            //Int64 b = Convert.ToInt64("878");
            ////=Convert.ToBoolean
            ////    Convert.ToDecimal
            ////    Convert.
            //string s = 89.ToString();
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            int output;
            bool IsNumber = int.TryParse("asdasd",out output);
            Console.WriteLine(IsNumber);
            Console.WriteLine(output);
        }
    }
}
