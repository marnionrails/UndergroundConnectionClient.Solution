// using System.Collections.Generic;
// using System;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;
// using Microsoft.EntityFrameworkCore;

// namespace UndergroundConnectionsClient.Models
// {
//   public class UndergroundConnectionsClientContext : DbContext
//   {
//     public DbSet<Artist> Artists { get; set; }
//     public DbSet<Classification> Classifications { get; set; }

//     public DbSet<ArtistClassification> ArtistClassification { get; set; }

//     public UndergroundConnectionsClientContext(DbContextOptions options) : base(options) {}

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//       optionsBuilder.UseLazyLoadingProxies();
//     }
//   }
// }

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