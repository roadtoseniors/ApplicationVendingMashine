using System;
using System.Collections.Generic;

namespace ApplicationVendingMashine.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Guid { get; set; } = null!;

    public string? Name { get; set; }

    public string? Price { get; set; }

    public int? MinStock { get; set; }

    public string? VendingMachineGuid { get; set; }

    public string? Description { get; set; }

    public int? QuantityAvailable { get; set; }

    public string? SalesTrend { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

    public virtual VendingMashine? VendingMachine { get; set; }
}
