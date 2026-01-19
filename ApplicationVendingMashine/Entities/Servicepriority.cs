using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApplicationVendingMashine.Entities;

public partial class Servicepriority
{
    public int Id { get; set; }

    public string? ServicePriority { get; set; }
    [JsonIgnore]

    public virtual ICollection<VendingMashine> VendingMashines { get; set; } = new List<VendingMashine>();
}
