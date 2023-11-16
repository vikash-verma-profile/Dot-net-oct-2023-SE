using connectwithentity.Models;
namespace connectwithentity
{
    internal class Program
    {
        public static void InsertData(Employee emp, BookdbContext db)
        {
            emp.Employeename = "Suresh";
            emp.Salary = 100;
            emp.DepartmentId = 2;
            db.Employees.Add(emp);
            db.SaveChanges();
            Console.WriteLine("record is being added succesfully.");
        }

        public static void ListData(BookdbContext db)
        {
            var employeelist = db.Employees;
            foreach (var item in employeelist)
            {
                Console.WriteLine(item.Id + "|" + item.Employeename + "|" + item.Salary +
                    "|" + item.DepartmentId
                    );
            }
        }

        public static void UpdateData(Employee emp, BookdbContext db)
        {
            db.Employees.Update(emp);
            db.SaveChanges();
        }
        public static void DeleteData(int id, BookdbContext db)
        {
            var emp = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            db.Employees.Remove(emp);
            db.SaveChanges();
        }
        static void Main(string[] args)
        {
            BookdbContext db = new BookdbContext();
            Console.WriteLine("Please enter a choice you want to do 1.Add 2.Update 3.Delete 4.List 5.Exit");
        }
    }
}