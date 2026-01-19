using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApplicationVendingMashine.Entities;

public partial class Paymentmetod
{
    public int Id { get; set; }

    public string? Paymentmetod1 { get; set; }

    [JsonIgnore]
    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
