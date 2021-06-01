using e_commerce.Aggregates.CustomerAgg;
using e_commerce.Aggregates.OrderAgg;
using e_commerce.Aggregates.ProductAgg;
using Microsoft.EntityFrameworkCore;

public class EcommerceContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderLineItem> OrderLineItems { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Address> Addresses { get; set; }
    //public DbSet<BillingRecord> BillingRecords { get; set; }
    //public DbSet<BillingRecordItem> BillingRecordItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ecommerce;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

}