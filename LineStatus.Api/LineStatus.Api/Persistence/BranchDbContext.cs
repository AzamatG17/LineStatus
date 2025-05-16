using LineStatus.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LineStatus.Api.Persistence;

public class BranchDbContext : DbContext
{
    public DbSet<cds_desk> cds_desk { get; set; }
    public DbSet<cds_desk_service> cds_desk_service { get; set; }
    public DbSet<cds_service> cds_service { get; set; }
    public DbSet<cds_ticket> cds_ticket { get; set; }

    public BranchDbContext(DbContextOptions<BranchDbContext> options)
        : base(options)
    { }
}
