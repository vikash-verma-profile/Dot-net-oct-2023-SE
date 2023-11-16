using System;
using System.Collections.Generic;

namespace connectwithentity.Models;

public partial class TblCustomer
{
    public int Id { get; set; }

    public string? CustomerName { get; set; }

    public string? ContactName { get; set; }

    public string? City { get; set; }
}
