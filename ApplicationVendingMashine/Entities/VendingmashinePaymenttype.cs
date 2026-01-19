using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApplicationVendingMashine.Entities;

public partial class VendingmashinePaymenttype
{
    public int Id { get; set; }
    [JsonIgnore]
    public int? VendingMashineId { get; set; }
    [JsonIgnore]
    public int? PaymentId { get; set; }

    public virtual Paymenttype? Payment { get; set; }

    public virtual VendingMashine? VendingMashine { get; set; }
}
