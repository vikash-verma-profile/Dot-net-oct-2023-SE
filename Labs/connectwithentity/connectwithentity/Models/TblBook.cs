using System;
using System.Collections.Generic;

namespace connectwithentity.Models;

public partial class TblBook
{
    public int Id { get; set; }

    public string? BookName { get; set; }

    public string? Description { get; set; }
}
