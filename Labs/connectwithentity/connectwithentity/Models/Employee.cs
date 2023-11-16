using System;
using System.Collections.Generic;

namespace connectwithentity.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Employeename { get; set; }

    public decimal? Salary { get; set; }

    public int? DepartmentId { get; set; }

    public string? EmpId { get; set; }
}
