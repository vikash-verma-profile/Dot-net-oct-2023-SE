using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class TblLogin
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? IsAdmin { get; set; }

    public string? Name { get; set; }
}
