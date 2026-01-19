using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApplicationVendingMashine.Entities;

public partial class Paymenttype
{
    public int Id { get; set; }

    public string? PaymentType { get; set; }

    [JsonIgnore]
    public virtual ICollection<VendingmashinePaymenttype> VendingmashinePaymenttypes { get; set; } = new List<VendingmashinePaymenttype>();
}
