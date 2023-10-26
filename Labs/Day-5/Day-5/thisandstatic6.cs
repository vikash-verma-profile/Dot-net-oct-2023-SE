using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    //in static class all members should be static
    static class DemoStatic
    {
        
    }
    class D
    {
        private D() { }
    }
    class Demo
    {
        static Demo()
        {
            Console.WriteLine("Hello");
        }
        public static int b=0;
        int a;
       public Demo(int a) {
            this.a = a;
        }  
        public void Print()
        {
            Console.WriteLine(a);
        }
    }
    internal class thisandstatic6
    {
        public static void Main6()
        {
            Demo d = new Demo(2);
            d.Print();
            Demo.b = 5;
            Console.WriteLine(Demo.b);
           // D d1 = new D();
        }
    }
}
