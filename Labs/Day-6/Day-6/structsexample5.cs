using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{

    struct student
    {
        //fields
        //parameterized constructors
        //contants
        //properties
        //events methods and idexers

        public string Name;
        public int Rollno;
    }
    internal class structsexample5
    {
        public static void Main()
        {
            student student;
            student.Name = "Vikash";
            student.Rollno = 101;

            Console.WriteLine(student.Name);    Console.WriteLine(student.Rollno);
        }
    }
}
