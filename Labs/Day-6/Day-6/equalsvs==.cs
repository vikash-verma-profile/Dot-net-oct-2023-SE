using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class equalsvs__
    {
        public static void Main3()
        {
            object name = "vikash";
            // string myname = name;
            char[] chars = { 'v', 'i', 'k', 'a', 's', 'h' };
            object myname = new string(chars);
            //Console.WriteLine(name==myname);
            //Console.WriteLine(name.Equals(myname));

            Console.WriteLine(name == myname);
            Console.WriteLine(myname.Equals(name));
        }
    }
}
