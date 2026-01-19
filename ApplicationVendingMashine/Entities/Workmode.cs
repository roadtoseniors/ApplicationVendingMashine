using System;
using System.Collections.Generic;

namespace ApplicationVendingMashine.Entities;

public partial class Workmode
{
    public int Id { get; set; }

    public string? WorkMode { get; set; }

    public virtual ICollection<VendingMashine> VendingMashines { get; set; } = new List<VendingMashine>();
}
