using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Sample
    {
        //public Sample() {
        //    Console.WriteLine("Hello i am coming from sample");
        //}
        public Sample(int x)
        {
            Console.WriteLine("x is " + x);    
        }
    }
    class Sample2:Sample
    {
        public Sample2(int y):base(y)
        {
            Console.WriteLine("Hello i am coming from sample2");
        }
    }
    internal class baseke4
    {
        public static void Main()
        {
            Sample2 s = new Sample2(8);
        }
    }
}
