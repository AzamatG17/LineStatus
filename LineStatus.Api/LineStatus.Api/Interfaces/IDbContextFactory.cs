using LineStatus.Api.Persistence;

namespace LineStatus.Api.Interfaces;

public interface IDbContextFactory
{
    Task<BranchDbContext> CreateAsync(int branchId);
}
