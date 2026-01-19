using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApplicationVendingMashine.Entities;

public partial class Repair
{
    public int Id { get; set; }

    public string? Date { get; set; }

    public string? IssuesFound { get; set; }
    
    [JsonIgnore]
    public string? VendingMachineGuid { get; set; }

    public int? FullName { get; set; }

    public string? WorkDescription { get; set; }

    public virtual VendingMashine? VendingMachine { get; set; }
}
