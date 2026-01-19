using System;
using System.Collections.Generic;

namespace ApplicationVendingMashine.Entities;

public partial class Operator
{
    public int Id { get; set; }

    public string? Operator1 { get; set; }

    public virtual ICollection<VendingMashine> VendingMashines { get; set; } = new List<VendingMashine>();
}
