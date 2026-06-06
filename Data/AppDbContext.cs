using Microsoft.EntityFrameworkCore;
using ExamenAPi.Models;

namespace ExamenAPi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}