using LineStatus.Api.Interfaces;
using LineStatus.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LineStatus.Api.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<cds_branch> cds_branch { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
