using EShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EShop.Infrastructure.Persistance;
public class EShopDbContext : DbContext
{

    public EShopDbContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=::1; Port=5433; Database=UserRegister; User Id=postgres; Password=postgres;");
    }
    public DbSet<User> Users { get; set; }
}
