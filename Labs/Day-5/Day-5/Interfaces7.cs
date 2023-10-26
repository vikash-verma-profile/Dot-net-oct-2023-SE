using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    interface IA
    {
        void Show();
    }
    class Dummy : IA
    {
        public void Show()
        {
            Console.WriteLine("I am printed in dummy class");
        }
    }
    internal class Interfaces7
    {
        public static void Main()
        {
            Dummy d = new Dummy();
            d.Show();
        }
    }
}
