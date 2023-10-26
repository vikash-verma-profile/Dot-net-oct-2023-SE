using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    //sealed class cannot be extended
    sealed class A
    {

    }
    class B //:A
    { 
    
    }
    //abstract class object can't be created
     abstract class AA
    {
        public abstract void Print();
    }
    class BB:AA
    {
        public override void Print()
        {
            Console.WriteLine("Hello");
        }
    }
    internal class abstractvsSealed5
    {
        public static void Main()
        {
            A a=new A();
           // AA a = new AA();
        }
    }
}
