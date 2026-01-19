using ApplicationVendingMashine.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddCors();

var app = builder.Build();
app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.MapGet("/api/companies", (MyDbContext context) =>
{
    return context.Companies.ToList();
});

app.MapGet("/api/CriticalThresholdTemplates", (MyDbContext context) =>
{
    return context.CriticalThresholdTemplates.ToList();
});

app.MapGet("/api/models", (MyDbContext context) =>
{
    return context.Models.ToList();
});

app.MapGet("/api/notificationstemplates", (MyDbContext context) =>
{
    return context.Notificationtemplates.ToList();
});

app.MapGet("/api/operators", (MyDbContext context) =>
{
    return context.Operators.ToList();
});

app.MapGet("/api/paymentmetods", (MyDbContext context) =>
{
    return context.Paymentmetods.ToList();
});

app.MapGet("/api/paymenttypes", (MyDbContext context) =>
{
    return context.Paymenttypes.ToList();
});

app.MapGet("/api/places", (MyDbContext context) =>
{
    return context.Places.ToList();
});
app.MapGet("/api/products", (MyDbContext context) =>
{
    return context.Products.ToList();
});

app.MapGet("/api/repairs", (MyDbContext context) =>
{
    return context.Repairs.ToList();
});

app.MapGet("/api/roles", (MyDbContext context) =>
{
    return context.Roles.ToList();
});

app.MapGet("/api/sales", (MyDbContext context) =>
{
    return context.Sales.ToList();
});

app.MapGet("/api/servicepriorities", (MyDbContext context) =>
{
    return context.Servicepriorities.ToList();
});

app.MapGet("/api/statuses", (MyDbContext context) =>
{
    return context.Statuses.ToList();
});

app.MapGet("/api/users", (MyDbContext context) =>
{
    return context.Users.ToList();
});

app.MapGet("/api/vendingsmashines", (MyDbContext context) =>
{
    return context.VendingMashines.ToList();
});

app.MapGet("/api/vendingmashinepaymenttypes", (MyDbContext context) =>
{
    return context.VendingmashinePaymenttypes.ToList();
});

app.MapGet("/api/workmodes", (MyDbContext context) =>
{
    return context.Workmodes.ToList();
});

app.Run();