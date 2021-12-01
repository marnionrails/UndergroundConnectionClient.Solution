using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UndergroundConnectionsClient.Models;

public class UndergroundConnectionsContext : IdentityDbContext<ApplicationUser>
{
    public UndergroundConnectionsContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
}
