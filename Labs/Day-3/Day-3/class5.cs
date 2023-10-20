using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    //encapsulation and abstraction
    class Student
    {
        //properties
        //fields
        //instance variables
        //constructors
        //destructors
        //indexers
        //methods
        //public int rollNo; //camel
        //public string studentName;

        int rollNo;
        string studentName;

        public void GetStudentData()
        {
            Console.WriteLine("Please enter student name");
            studentName = Console.ReadLine();
            Console.WriteLine("Please enter roll No");
            rollNo=Convert.ToInt32(Console.ReadLine());
        }
        public void PrintStudentData()
        {
            Console.WriteLine("Student RollNo :" + rollNo);
            Console.WriteLine("Student Name :"+studentName);
        }
    }
    internal class class5
    {
        public static void Main()
        {
            Student[] StudentList = new Student[2]; 
            for (int i=0; i<StudentList.Length; i++) {
                Student std = new Student();
                std.GetStudentData();
                StudentList[i]= std;
            }
            for (int i = 0; i < StudentList.Length; i++)
            {
                StudentList[i].PrintStudentData();
            }
            //std.rollNo = 1;
            //std.studentName = "Vikash";
            //Console.WriteLine(std.rollNo);
            //Console.WriteLine(std.studentName);
            //std.GetStudentData();
            //std.PrintStudentData();
        }
    }
}
