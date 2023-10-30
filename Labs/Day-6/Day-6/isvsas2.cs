using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    public class P
    {

    }
    public class P1 : P { }
    public class P2 { }
    internal class isvsas2
    {
        public static void Main()
        {
            P o1 = new P();
            P1 o2=new P1();
            Console.WriteLine(o1 is P);
            Console.WriteLine(o1 is Object);
            Console.WriteLine(o2 is P1);
            Console.WriteLine(o2 is Object);
            Console.WriteLine(o1 is P2);
            Console.WriteLine(o2 is P2);
        }
    }
}
