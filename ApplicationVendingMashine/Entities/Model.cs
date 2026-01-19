using System;
using System.Collections.Generic;

namespace ApplicationVendingMashine.Entities;

public partial class Model
{
    public int Id { get; set; }

    public string? Model1 { get; set; }

    public virtual ICollection<VendingMashine> VendingMashines { get; set; } = new List<VendingMashine>();
}
