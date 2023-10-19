using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class conditional
    {
        public static void Main3()
        {
            bool breakFlag = false; //break condition so that we can break
            //our infinite loop
            while (true) //infinite loop
            {
                Console.WriteLine("Please enter some choice");
                Console.WriteLine("1.Add\r\n2.MUL\r\n3.SUB\r\n4.Divide\r\n5.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You have chossen add");
                        break;
                    case 5:
                        Console.WriteLine("Thanks for choosing Us");
                        breakFlag = true;
                        break;
                    default:
                        Console.WriteLine("Please enter some valid choice");
                        break;
                }
                if (breakFlag)
                {
                    break;
                }
            }
          
        }
    }
}
