using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    class Employee
    {
        public string EmployeeID { get; set; }

        public string EmployeeName { get; set; }
        public override string ToString()
        {
            return EmployeeID+" | "+EmployeeName;
        }
    }
    internal class ReadWritefromFile
    {
        public static void WriteInFile(string filePath,Employee employee)
        {
            File.WriteAllText(filePath, employee.ToString());
        }
        public static string ReadFromFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
        public static void Main()
        {
            string filePath = "C:\\Users\\LEVEL UP SOLUTIONS 1\\Desktop\\Dot-net-oct-2023-SE\\Labs\\Day-9\\Day-9\\file\\Textfile.txt";
            WriteInFile(filePath,new Employee() { EmployeeID="Emp101",EmployeeName="Vikash"});
            Console.WriteLine("Your content is being written");
            Console.WriteLine(ReadFromFile(filePath));
        }
    }
}
