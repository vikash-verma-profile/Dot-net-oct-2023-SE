using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1 = 1;
            int Number2 = 5;
            int Number3 = 10;

            if (Number1 > Number2 && Number1>Number3 )
            {
                Console.WriteLine(Number1+" greater Number");
            }
            else if (Number2> Number1 && Number2 > Number3)
            {
                Console.WriteLine(Number2 + " greater Number");
            }
            else
            {
                Console.WriteLine(Number3 + " is greater Number");
            }




            //Console.WriteLine("Please enter some value : ");
            //string inputvalue = Console.ReadLine();
            //Console.WriteLine("The value that you have entered is "+inputvalue);
            ////<data type> variable-name
                ///*
                // asdasdasdasd
                // asdasd*/
                //Console.WriteLine("Hello World!jhg asdjhas djhg asdjh asdjfa sd");
                //Console.WriteLine(a+b);

                //if (a > b)
                //{
                //    Console.WriteLine(a+" is greater than "+b);
                //}
                //else
                //{
                //    Console.WriteLine(b+" is greater than "+a);
                //}
        }
    }
}
