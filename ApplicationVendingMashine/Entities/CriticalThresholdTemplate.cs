using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApplicationVendingMashine.Entities;

public partial class CriticalThresholdTemplate
{
    public int Id { get; set; }

    public string? CriticalThresholdTemplate1 { get; set; }
    [JsonIgnore]

    public virtual ICollection<VendingMashine> VendingMashines { get; set; } = new List<VendingMashine>();
}
