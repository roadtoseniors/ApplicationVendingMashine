using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApplicationVendingMashine.Entities;

public partial class Sale
{
    public int Id { get; set; }

    public string? Timestamp { get; set; }

    [JsonIgnore]
    public string? ProductGuid { get; set; }

    public string? TotalPrice { get; set; }

    public int? Quantity { get; set; }

    public int? PaymentMethod { get; set; }

    public virtual Paymentmetod? PaymentMethodNavigation { get; set; }

    public virtual Product? Product { get; set; }
}
