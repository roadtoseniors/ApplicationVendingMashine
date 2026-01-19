using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApplicationVendingMashine.Entities;

public partial class User
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? FullName { get; set; }

    public int? IsManager { get; set; }

    public int? IsEngineer { get; set; }

    public string? Phone { get; set; }

    [JsonIgnore]
    public string Guid { get; set; } = null!;

    public int? IsOperator { get; set; }

    public int? Role { get; set; }

    public virtual Role? RoleNavigation { get; set; }
    [JsonIgnore]

    public virtual ICollection<VendingMashine> VendingMashines { get; set; } = new List<VendingMashine>();
}
