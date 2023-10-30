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

    class x
    {

    }
    class y
    {

    }
    internal class isvsas2
    {
        public static void Main()
        {
            /* is operator
            P o1 = new P();
            P1 o2=new P1();
            
            var result = o1 is P;
            Console.WriteLine(result);
            Console.WriteLine(o1 is Object);
            Console.WriteLine(o2 is P1);
            Console.WriteLine(o2 is Object);
            Console.WriteLine(o1 is P2);
            Console.WriteLine(o2 is P2);

            */

            /* as Operator*/

            object[] o = new object[5];
            o[0] = new y();
            o[1] = new x();
            o[2] = "Vikash";
            o[3] = 232323.0;
            o[4] = null;

            foreach (var x in o)
            {
                string str = x as string;
               
                if(str!=null)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine("it is not a string value");
                }
            }


        }
    }
}
