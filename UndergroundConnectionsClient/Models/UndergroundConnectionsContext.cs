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
<<<<<<< HEAD
}
=======
}
>>>>>>> eb367d86c5412eca5518f2cba807d8b5a330567f
