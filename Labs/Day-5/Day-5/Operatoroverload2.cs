using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Calculator
    {
        public int Number1, Number2;
        public Calculator(int num1,int num2)
        {
                Number1 = num1;
                Number2 = num2;
        }
        public void Print()
        {
            Console.WriteLine("Number1= "+Number1);
            Console.WriteLine("Number2= " + Number2);
        }
        public static Calculator operator +(Calculator a, Calculator b)
        {
            Calculator c = new Calculator(0,0);
            c.Number1=a.Number1+b.Number1;
            c.Number2= a.Number2+b.Number2;
            return c;
        }
    }
    internal class Operatoroverload2
    {
        static void Main2(string[] args)
        {
            Calculator c1=new Calculator(1, 2);
            Calculator c2=new Calculator(2, 3);
            Calculator c3=new Calculator(0, 0);
            c3 = c1 + c2;
            c3.Print();
        }
    }
}
