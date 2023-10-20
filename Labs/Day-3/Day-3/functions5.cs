﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    //in vs out vs ref
    // ref vs out
    internal class functions5
    {
        //out paramerter should be assigned some value inside function before 
        //returning
        public static void sumOut(in int a,in int b,out int c)
        {
             c = a + b;
            //Console.WriteLine(a + b);
        }
        //ref should be assigned before passing to a function
        public static void sumRef(ref int a,ref int b)
        {
            Console.WriteLine(a+b);
        }
       
        public static void sumP(int a,int b=2)
        {
            Console.WriteLine(a+b);
        }
        public static void SumN(int a,int b,int c)
        {
            Console.WriteLine(a+b+c);
        }
        public static void Main5()
        {
            int result,Number1, Number2;
            //Number1 = 1;
            //Number2=2;
            //sumOut(Number1, Number2, out result);
            //sumRef(ref Number1,ref Number2);
            //Console.WriteLine(result);
            sumP(1,5);
            SumN(c: 3, a: 8, b: 9);
        }
    }
}
