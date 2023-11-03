using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        public static void WriteInFile(string filePath,List<Employee> employee)
        {
            var jsonData=JsonConvert.SerializeObject(employee);
            File.WriteAllText(filePath, jsonData);
        }
        public static List<Employee> ReadFromFile(string filePath)
        {
            return JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(filePath));
        }
        public static void Main3()
        {
            string filePath = "C:\\Users\\LEVEL UP SOLUTIONS 1\\Desktop\\Dot-net-oct-2023-SE\\Labs\\Day-9\\Day-9\\file\\Textfile.txt";
            WriteInFile(filePath,new List<Employee> { new Employee() { EmployeeID = "Emp101", EmployeeName = "Vikash" } });
            Console.WriteLine("Your content is being written");
            foreach (var item in ReadFromFile(filePath))
            {
                Console.WriteLine(item.EmployeeID+" | "+item.EmployeeName);
            }
           
        }
    }
}
