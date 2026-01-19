using System;
using System.Collections.Generic;

namespace ApplicationVendingMashine.Entities;

public partial class Place
{
    public int Id { get; set; }

    public string? Place1 { get; set; }

    public virtual ICollection<VendingMashine> VendingMashines { get; set; } = new List<VendingMashine>();
}
