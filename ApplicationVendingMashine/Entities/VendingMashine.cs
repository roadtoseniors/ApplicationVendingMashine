using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApplicationVendingMashine.Entities;

public partial class VendingMashine
{
    public int Id { get; set; }

    public int? SerialNumber { get; set; }

    public string? Name { get; set; }
    [JsonIgnore]

    public string? UserGuid { get; set; }

    public string? RfidCashCollection { get; set; }

    public string? Notes { get; set; }

    public string? Location { get; set; }

    public int? WorkMode { get; set; }

    public string? RfidLoading { get; set; }

    public int? Model { get; set; }

    public string? KitOnlineId { get; set; }

    public int? Company { get; set; }

    public string? PaymentType { get; set; }

    public int? CriticalThresholdTemplate { get; set; }

    public int? ServicePriority { get; set; }

    public int? Manager { get; set; }

    public int? Status { get; set; }

    public int? NotificationTemplate { get; set; }

    public string? WorkingHours { get; set; }

    public int? Engineer { get; set; }
    [JsonIgnore]

    public string Guid { get; set; } = null!;

    public string? InstallDate { get; set; }

    public int? Place { get; set; }

    public int? Operator { get; set; }

    public int? Technician { get; set; }

    public string? LastMaintenanceDate { get; set; }

    public string? RfidService { get; set; }

    public string? Coordinates { get; set; }

    public string? TotalIncome { get; set; }

    public string? Timezone { get; set; }

    public virtual Company? CompanyNavigation { get; set; }

    public virtual CriticalThresholdTemplate? CriticalThresholdTemplateNavigation { get; set; }

    public virtual Model? ModelNavigation { get; set; }

    public virtual Notificationtemplate? NotificationTemplateNavigation { get; set; }

    public virtual Operator? OperatorNavigation { get; set; }

    public virtual Place? PlaceNavigation { get; set; }
    [JsonIgnore]

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    [JsonIgnore]

    public virtual ICollection<Repair> Repairs { get; set; } = new List<Repair>();

    public virtual Servicepriority? ServicePriorityNavigation { get; set; }

    public virtual Status? StatusNavigation { get; set; }

    public virtual User? User { get; set; }
    [JsonIgnore]

    public virtual ICollection<VendingmashinePaymenttype> VendingmashinePaymenttypes { get; set; } = new List<VendingmashinePaymenttype>();

    public virtual Workmode? WorkModeNavigation { get; set; }
}
