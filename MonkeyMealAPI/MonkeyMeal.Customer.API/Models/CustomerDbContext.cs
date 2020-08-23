using Microsoft.EntityFrameworkCore;
using Models;
using MySql.Data.EntityFrameworkCore;

public class CustomerDbContext : DbContext
{
    string connectionString = "server=localhost;port=8080;database=emtrordb;";
    public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
    {

    }
    public DbSet<Customer> Customer { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}