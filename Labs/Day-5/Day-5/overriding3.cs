using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class class1
    {
        public virtual void show()
        {
            Console.WriteLine("Hello i am in class1.show");
        }
    }
    class class2:class1
    {
        public override void show()
        {
            Console.WriteLine("Hello i am in class2.show");
        }
    }
    internal class overriding3
    {
        public static void Main()
        {
            class1 c = new class2();
            c.show();
        }
    }
}
