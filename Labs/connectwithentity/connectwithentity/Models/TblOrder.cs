using System;
using System.Collections.Generic;

namespace connectwithentity.Models;

public partial class TblOrder
{
    public string? OrderId { get; set; }

    public int? CustomerId { get; set; }

    public int? EmlopyeeId { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? ShipperId { get; set; }
}
