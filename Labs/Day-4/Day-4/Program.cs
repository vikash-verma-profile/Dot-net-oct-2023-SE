using System.Runtime;

namespace Day_4
{
    public class Student
    {
        //fields
        //properties
        //functions
        //constructors
        //destructors
        //indexers

        int RollNo;
        string StudentName;

        public void GetData()
        {
            Console.WriteLine("Please enter student roll no :");
            RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student name :");
            StudentName = Console.ReadLine();
        }

        public void PrintData()
        {
            Console.WriteLine("Student Data :");
            Console.WriteLine("Roll No | Student Name");
            Console.WriteLine(RollNo + "      |" + StudentName);
        }
        public static void PrintStudentList(Student[] students)
        {
            Console.WriteLine("Roll No | Student Name");
            foreach (Student student in students)
            {
                if (student != null)
                {
                    Console.WriteLine(student.RollNo + "      |" + student.StudentName);
                }
            }
        }
        public static Student[] UpdateStudentByRollNO(int rollNo, Student[] students, string newStudentName)
        {
            Student[] studentList = new Student[5];
            int counter = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.RollNo == rollNo)
                    {
                        Student s = new Student();
                        s.RollNo = rollNo;
                        s.StudentName = newStudentName;
                        studentList[counter] = s; counter++;
                    }
                    else
                    {
                        studentList[counter] = student; counter++;
                    }
                }
            }
            return studentList;
        }

        public static Student[] DeleteStudentByRollNO(int rollno, Student[] students)
        {
            Student[] studentList = new Student[5];
            return studentList;
        }
    }
    public class Program
    {

        static void Main1(string[] args)
        {
            bool loopBreaker = false;
            Student[] studentList = new Student[5];
            int counter = 0;
            while (true)
            {
                Console.WriteLine("====================================================");
                Console.WriteLine("Please select an operation to perform from below\r\n1. Add student\r\n2. Edit Student \r\n3. Delete Student\r\n4. List Student\r\n5. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Student student = new Student();
                        student.GetData();
                        studentList[counter] = student;
                        counter++;
                        break;
                    case 2:
                        Console.WriteLine("Please enter student Roll no");
                        Student.PrintStudentList(studentList);
                        int RollNo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter student name you want to update ");
                        string studentName = Console.ReadLine();
                        studentList = Student.UpdateStudentByRollNO(RollNo, studentList, studentName);
                        Console.WriteLine("your record is being updated successfully");
                        break;
                    case 3:
                        Console.WriteLine("Please enter student Roll no");
                        Student.PrintStudentList(studentList);
                        int RollNoNew = int.Parse(Console.ReadLine());
                        studentList = Student.DeleteStudentByRollNO(RollNoNew, studentList);
                        Console.WriteLine("your record is being deleted successfully");
                        break;
                    case 4:
                        Student.PrintStudentList(studentList);
                        break;
                    case 5:
                        loopBreaker = true;
                        break;

                    default:
                        break;
                }
                if (loopBreaker)
                {
                    Console.WriteLine("Thank you for using our application");
                    break;
                }
            }
        }
    }
}