using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UndergroundConnectionsClient.Models;

public class UndergroundConnectionsClientContext : IdentityDbContext<ApplicationUser>
{
    public UndergroundConnectionsClientContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
}