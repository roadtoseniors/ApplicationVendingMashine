using System;
using System.Collections.Generic;

namespace ApplicationVendingMashine.Entities;

public partial class Notificationtemplate
{
    public int Id { get; set; }

    public string? NotificationTemplate { get; set; }

    public virtual ICollection<VendingMashine> VendingMashines { get; set; } = new List<VendingMashine>();
}
