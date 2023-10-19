using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class refvsvaluetype
    {
        //defination of a function
        public static void swap(ref int Number1,ref int Number2)
        {
            int temp=Number1;
            Number1=Number2;
            Number2=temp;
            Console.WriteLine("Number1= "+Number1+" Number2= "+Number2);
        }
        public static void Main4()
        {
            int Number1=20,Number2=10;
            Console.WriteLine("Number1= " + Number1 + " Number2= " + Number2);
            //calling a function
            swap(ref Number1,ref Number2);
            Console.WriteLine("Values in main post swap");
            Console.WriteLine("Number1= " + Number1 + " Number2= " + Number2);
        }
    }
}
