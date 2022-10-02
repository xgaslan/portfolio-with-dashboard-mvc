using Microsoft.EntityFrameworkCore;

namespace Portfolio.DataAccess.Concrete;

public class BaseContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=XGASLAN;Initial Catalog=PortfolioDB;User ID=gaslan;Password=3akqrtww;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}