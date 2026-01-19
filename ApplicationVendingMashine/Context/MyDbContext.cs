using System;
using System.Collections.Generic;
using ApplicationVendingMashine.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationVendingMashine.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CriticalThresholdTemplate> CriticalThresholdTemplates { get; set; }

    public virtual DbSet<Model> Models { get; set; }

    public virtual DbSet<Notificationtemplate> Notificationtemplates { get; set; }

    public virtual DbSet<Operator> Operators { get; set; }

    public virtual DbSet<Paymentmetod> Paymentmetods { get; set; }

    public virtual DbSet<Paymenttype> Paymenttypes { get; set; }

    public virtual DbSet<Place> Places { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Repair> Repairs { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Servicepriority> Servicepriorities { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VendingMashine> VendingMashines { get; set; }

    public virtual DbSet<VendingmashinePaymenttype> VendingmashinePaymenttypes { get; set; }

    public virtual DbSet<Workmode> Workmodes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=vendingmashinetest;Username=postgres;Password=postgres");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("company_pk");

            entity.ToTable("company");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Company1).HasColumnName("company");
        });

        modelBuilder.Entity<CriticalThresholdTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("critical_threshold_template_pk");

            entity.ToTable("critical_threshold_template");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.CriticalThresholdTemplate1).HasColumnName("critical_threshold_template");
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("model_pk");

            entity.ToTable("model");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Model1).HasColumnName("model");
        });

        modelBuilder.Entity<Notificationtemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("notificationtemplate_pk");

            entity.ToTable("notificationtemplate");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.NotificationTemplate).HasColumnName("notification_template");
        });

        modelBuilder.Entity<Operator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("operator_pk");

            entity.ToTable("operator");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Operator1).HasColumnName("operator");
        });

        modelBuilder.Entity<Paymentmetod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("paymentmetod_pk");

            entity.ToTable("paymentmetod");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Paymentmetod1).HasColumnName("paymentmetod");
        });

        modelBuilder.Entity<Paymenttype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("paymenttype_pk");

            entity.ToTable("paymenttype");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.PaymentType).HasColumnName("payment_type");
        });

        modelBuilder.Entity<Place>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("place_pk");

            entity.ToTable("place");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Place1).HasColumnName("place");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pk");

            entity.ToTable("products");

            entity.HasIndex(e => e.Guid, "products_pk_2").IsUnique();

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.MinStock).HasColumnName("min_stock");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.QuantityAvailable).HasColumnName("quantity_available");
            entity.Property(e => e.SalesTrend).HasColumnName("sales_trend");
            entity.Property(e => e.VendingMachineGuid).HasColumnName("vending_machine_guid");

            entity.HasOne(d => d.VendingMachine).WithMany(p => p.Products)
                .HasPrincipalKey(p => p.Guid)
                .HasForeignKey(d => d.VendingMachineGuid)
                .HasConstraintName("products_vending_mashine_guid_fk");
        });

        modelBuilder.Entity<Repair>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("repair_pk");

            entity.ToTable("repair");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.IssuesFound).HasColumnName("issues_found");
            entity.Property(e => e.VendingMachineGuid).HasColumnName("vending_machine_guid");
            entity.Property(e => e.WorkDescription).HasColumnName("work_description");

            entity.HasOne(d => d.VendingMachine).WithMany(p => p.Repairs)
                .HasPrincipalKey(p => p.Guid)
                .HasForeignKey(d => d.VendingMachineGuid)
                .HasConstraintName("repair_vending_mashine_guid_fk");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("role_pk");

            entity.ToTable("role");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Role1).HasColumnName("role");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sales_pk");

            entity.ToTable("sales");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.PaymentMethod).HasColumnName("payment_method");
            entity.Property(e => e.ProductGuid).HasColumnName("product_guid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            entity.Property(e => e.TotalPrice).HasColumnName("total_price");

            entity.HasOne(d => d.PaymentMethodNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.PaymentMethod)
                .HasConstraintName("sales_paymentmetod_id_fk");

            entity.HasOne(d => d.Product).WithMany(p => p.Sales)
                .HasPrincipalKey(p => p.Guid)
                .HasForeignKey(d => d.ProductGuid)
                .HasConstraintName("sales_products_guid_fk");
        });

        modelBuilder.Entity<Servicepriority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("servicepriority_pk");

            entity.ToTable("servicepriority");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.ServicePriority).HasColumnName("service_priority");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("status_pk");

            entity.ToTable("status");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Status1).HasColumnName("status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pk");

            entity.ToTable("users");

            entity.HasIndex(e => e.Guid, "users_pk_2").IsUnique();

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.IsEngineer).HasColumnName("is_engineer");
            entity.Property(e => e.IsManager).HasColumnName("is_manager");
            entity.Property(e => e.IsOperator).HasColumnName("is_operator");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Role).HasColumnName("role");

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Role)
                .HasConstraintName("users_role_id_fk");
        });

        modelBuilder.Entity<VendingMashine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vending_mashine_pk");

            entity.ToTable("vending_mashine");

            entity.HasIndex(e => e.Guid, "vending_mashine_pk_2").IsUnique();

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Company).HasColumnName("company");
            entity.Property(e => e.Coordinates).HasColumnName("coordinates");
            entity.Property(e => e.CriticalThresholdTemplate).HasColumnName("critical_threshold_template");
            entity.Property(e => e.Engineer).HasColumnName("engineer");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.InstallDate).HasColumnName("install_date");
            entity.Property(e => e.KitOnlineId).HasColumnName("kit_online_id");
            entity.Property(e => e.LastMaintenanceDate).HasColumnName("last_maintenance_date");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Manager).HasColumnName("manager");
            entity.Property(e => e.Model).HasColumnName("model");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.NotificationTemplate).HasColumnName("notification_template");
            entity.Property(e => e.Operator).HasColumnName("operator");
            entity.Property(e => e.PaymentType).HasColumnName("payment_type");
            entity.Property(e => e.Place).HasColumnName("place");
            entity.Property(e => e.RfidCashCollection).HasColumnName("rfid_cash_collection");
            entity.Property(e => e.RfidLoading).HasColumnName("rfid_loading");
            entity.Property(e => e.RfidService).HasColumnName("rfid_service");
            entity.Property(e => e.SerialNumber).HasColumnName("serial_number");
            entity.Property(e => e.ServicePriority).HasColumnName("service_priority");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Technician).HasColumnName("technician");
            entity.Property(e => e.Timezone).HasColumnName("timezone");
            entity.Property(e => e.TotalIncome).HasColumnName("total_income");
            entity.Property(e => e.UserGuid).HasColumnName("user_guid");
            entity.Property(e => e.WorkMode).HasColumnName("work_mode");
            entity.Property(e => e.WorkingHours).HasColumnName("working_hours");

            entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.VendingMashines)
                .HasForeignKey(d => d.Company)
                .HasConstraintName("vending_mashine_company_id_fk");

            entity.HasOne(d => d.CriticalThresholdTemplateNavigation).WithMany(p => p.VendingMashines)
                .HasForeignKey(d => d.CriticalThresholdTemplate)
                .HasConstraintName("vending_mashine_critical_threshold_template_id_fk");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.VendingMashines)
                .HasForeignKey(d => d.Model)
                .HasConstraintName("vending_mashine_model_id_fk");

            entity.HasOne(d => d.NotificationTemplateNavigation).WithMany(p => p.VendingMashines)
                .HasForeignKey(d => d.NotificationTemplate)
                .HasConstraintName("vending_mashine_notificationtemplate_id_fk");

            entity.HasOne(d => d.OperatorNavigation).WithMany(p => p.VendingMashines)
                .HasForeignKey(d => d.Operator)
                .HasConstraintName("vending_mashine_operator_id_fk");

            entity.HasOne(d => d.PlaceNavigation).WithMany(p => p.VendingMashines)
                .HasForeignKey(d => d.Place)
                .HasConstraintName("vending_mashine_place_id_fk");

            entity.HasOne(d => d.ServicePriorityNavigation).WithMany(p => p.VendingMashines)
                .HasForeignKey(d => d.ServicePriority)
                .HasConstraintName("vending_mashine_servicepriority_id_fk");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.VendingMashines)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("vending_mashine_status_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.VendingMashines)
                .HasPrincipalKey(p => p.Guid)
                .HasForeignKey(d => d.UserGuid)
                .HasConstraintName("vending_mashine_users_guid_fk");

            entity.HasOne(d => d.WorkModeNavigation).WithMany(p => p.VendingMashines)
                .HasForeignKey(d => d.WorkMode)
                .HasConstraintName("vending_mashine_workmode_id_fk");
        });

        modelBuilder.Entity<VendingmashinePaymenttype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vendingmashine_paymenttype_pk");

            entity.ToTable("vendingmashine_paymenttype");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.PaymentId).HasColumnName("payment_id");
            entity.Property(e => e.VendingMashineId).HasColumnName("vending_mashine_id");

            entity.HasOne(d => d.Payment).WithMany(p => p.VendingmashinePaymenttypes)
                .HasForeignKey(d => d.PaymentId)
                .HasConstraintName("vendingmashine_paymenttype_paymenttype_id_fk");

            entity.HasOne(d => d.VendingMashine).WithMany(p => p.VendingmashinePaymenttypes)
                .HasForeignKey(d => d.VendingMashineId)
                .HasConstraintName("vendingmashine_paymenttype_vending_mashine_id_fk");
        });

        modelBuilder.Entity<Workmode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("workmode_pk");

            entity.ToTable("workmode");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.WorkMode).HasColumnName("work_mode");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
