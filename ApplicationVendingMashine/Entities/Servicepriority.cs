using System;
using System.Collections.Generic;

namespace ApplicationVendingMashine.Entities;

public partial class Servicepriority
{
    public int Id { get; set; }

    public string? ServicePriority { get; set; }

    public virtual ICollection<VendingMashine> VendingMashines { get; set; } = new List<VendingMashine>();
}
