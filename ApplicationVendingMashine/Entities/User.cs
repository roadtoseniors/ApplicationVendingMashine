using System;
using System.Collections.Generic;

namespace ApplicationVendingMashine.Entities;

public partial class User
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? FullName { get; set; }

    public int? IsManager { get; set; }

    public int? IsEngineer { get; set; }

    public string? Phone { get; set; }

    public string Guid { get; set; } = null!;

    public int? IsOperator { get; set; }

    public int? Role { get; set; }

    public virtual Role? RoleNavigation { get; set; }

    public virtual ICollection<VendingMashine> VendingMashines { get; set; } = new List<VendingMashine>();
}
