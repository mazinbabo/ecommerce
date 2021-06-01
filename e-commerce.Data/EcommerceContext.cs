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

    protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite("Data Source=ecommerce.db");
}