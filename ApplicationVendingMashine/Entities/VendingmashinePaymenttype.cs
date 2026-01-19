using System;
using System.Collections.Generic;

namespace ApplicationVendingMashine.Entities;

public partial class VendingmashinePaymenttype
{
    public int Id { get; set; }

    public int? VendingMashineId { get; set; }

    public int? PaymentId { get; set; }

    public virtual Paymenttype? Payment { get; set; }

    public virtual VendingMashine? VendingMashine { get; set; }
}
