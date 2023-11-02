using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{

    partial class Employee
    {
        partial void Print();
        public void DoWork()
        {
            Console.WriteLine("Do some work");
        }
    }
    partial class Employee {

        partial void Print()
        {
            Console.WriteLine("Hi i am defined in another class and my signature is in" +
                "different class");
        }
        public void GoToLunch()
        {
            Print();
            Console.WriteLine("Have some lunch");
        }
    }
    internal class PartialCLasses3
    {
        public static void Main3()
        {
            Employee emp=new Employee();
            emp.DoWork();
            emp.GoToLunch();
            
        }
    }
}
