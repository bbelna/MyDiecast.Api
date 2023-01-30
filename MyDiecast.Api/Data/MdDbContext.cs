using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyDiecast.Api.Data.Entities;

namespace MyDiecast.Api.Data {
  public class MdDbContext : IdentityDbContext<AspUser, AspRole, Guid> {
    public DbSet<AspRole> Roles { get; set; }
    public DbSet<AspUser> Users { get; set; }

    public DbSet<DiecastMake> Makes { get; set; }
    public DbSet<Diecast> Diecast { get; set; }
  }
}
