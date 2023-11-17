using connectdbwithcodefirstapproach.Models;

namespace connectdbwithcodefirstapproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDbContext db=new EmployeeDbContext();
            var employeeList = db.Employees.
                Select(x=>new {ID=x.ID,EmployeeName=x.Name});
            var employeelistIt = db.Employees.Where(x => x.DepartmentId == 1);
            foreach (var item in employeeList)
            {
                Console.WriteLine(item.ID+" | "+item.EmployeeName);
            }
            Console.WriteLine("==========================================");
            foreach (var item in employeelistIt)
            {
                Console.WriteLine(item.ID + " | " + item.Name);
            }
        }
    }
}