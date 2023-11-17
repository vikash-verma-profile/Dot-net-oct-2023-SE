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
            Console.WriteLine("==============Order By============================");
            var employeeListOrder=db.Employees.OrderBy(x => x.ID).ToList();
            var employeeListOrderDesc = db.Employees.OrderByDescending(x => x.ID).ToList();
            foreach (var item in employeeListOrder)
            {
                Console.WriteLine(item.ID + " | " + item.Name);
            }
            foreach (var item in employeeListOrderDesc)
            {
                Console.WriteLine(item.ID + " | " + item.Name);
            }
            Console.WriteLine("==============Group By============================");
            var employeeListGroup = db.Employees.GroupBy(x => x.Name).Select(x => new {Name=x.FirstOrDefault().Name}).ToList();
            foreach (var item in employeeListGroup)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("==============First Vs FirstORDefault============================");
            var employeeListFirst = db.Employees.Where(x => x.ID == 10).FirstOrDefault();

            Console.WriteLine("===========Join===========");
            var data = db.Employees.Join(db.Department, emp => emp.DepartmentId, dep => dep.Id
            , (emp, dep) => new { Id = emp.ID, EmployeeName = emp.Name, DepartmentName = dep.Name }
            );
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.EmployeeName +" | "+item.DepartmentName);
            }
            Console.WriteLine("===========Take===========");
            var dataTake = db.Employees.Take(2);
            foreach (var item in dataTake)
            {
                Console.WriteLine(item.ID + " | " + item.Name );
            }
            Console.WriteLine("===========Except===========");
            var number1 = new List<int>() { 1, 2, 3, 4 };
            var number2 = new List<int>() { 1, 2 };
            var numbes = number1.Except(number1);
            foreach (var item in numbes)
            {
                Console.WriteLine(item);
            }
        }
    }
}