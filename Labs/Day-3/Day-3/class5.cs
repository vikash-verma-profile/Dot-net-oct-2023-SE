using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Student
    {
        //properties
        //fields
        //instance variables
        //constructors
        //destructors
        //indexers
        //methods
       public int rollNo; //camel
       public string studentName;
    }
    internal class class5
    {
        public static void Main()
        {
            Student std=new Student();
            std.rollNo = 1;
            std.studentName = "Vikash";
            Console.WriteLine(std.rollNo);
            Console.WriteLine(std.studentName);
        }
    }
}
