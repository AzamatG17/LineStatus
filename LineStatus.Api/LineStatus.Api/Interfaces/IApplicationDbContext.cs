using LineStatus.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LineStatus.Api.Interfaces;

public interface IApplicationDbContext
{
    DbSet<cds_branch> cds_branch { get; set; }
}
