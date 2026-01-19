using System;
using System.Collections.Generic;

namespace ApplicationVendingMashine.Entities;

public partial class Paymenttype
{
    public int Id { get; set; }

    public string? PaymentType { get; set; }

    public virtual ICollection<VendingmashinePaymenttype> VendingmashinePaymenttypes { get; set; } = new List<VendingmashinePaymenttype>();
}
