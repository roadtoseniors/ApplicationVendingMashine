using System;
using System.Collections.Generic;

namespace ApplicationVendingMashine.Entities;

public partial class Paymentmetod
{
    public int Id { get; set; }

    public string? Paymentmetod1 { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
