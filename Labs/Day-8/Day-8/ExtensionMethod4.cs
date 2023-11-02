using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class ExtensionClass
    {
        public void E1()
        {
            Console.WriteLine("E1");
        }
        public void E2()
        {
            Console.WriteLine("E2");
        }
        public void E3()
        {
            Console.WriteLine("E3");

        }
        public void E4()
        {
            Console.WriteLine("E4");

        }
    }
    static class NewMethodClass
    {
        public static void E5(this ExtensionClass s)
        {
            Console.WriteLine("E5");
        }
    }
    internal class ExtensionMethod4
    {
        public static void Main4()
        {
            ExtensionClass ex=new ExtensionClass();
            ex.E1();
            ex.E2();
            ex.E3(); 
            ex.E4();
            ex.E5();
          
        }
    }
}
