using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class TblOrder
{
    public int Id { get; set; }

    public string? OrderNo { get; set; }

    public string? UserId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }
}
