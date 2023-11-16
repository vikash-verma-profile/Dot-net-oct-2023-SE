using System;
using System.Collections.Generic;

namespace connectwithentity.Models;

public partial class Address
{
    public int? AddressId { get; set; }

    public int? SalespersonId { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }
}
