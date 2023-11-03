using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    internal class Delegate4
    {
        public delegate void AddNumber(int x,int y);
       // public delegate void SubNumber(int x, int y);
        public void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Main()
        {
            Delegate4 obj= new Delegate4();

            AddNumber delObj = new AddNumber(obj.Sum);

            delObj(1, 2);
            delObj = new AddNumber(obj.Sub);
            delObj(1, 2);
        }
    }
}
