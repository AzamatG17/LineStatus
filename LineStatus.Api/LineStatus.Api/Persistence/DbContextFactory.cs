using LineStatus.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LineStatus.Api.Persistence;

public class DbContextFactory : IDbContextFactory
{
    private readonly IApplicationDbContext _context;

    public DbContextFactory(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<BranchDbContext> CreateAsync(int branchId)
    {
        var branch = await _context.cds_branch
            .AsNoTracking()
            .FirstOrDefaultAsync(b => b.branch_id == branchId)
            ?? throw new Exception("Branch not found");
        
        var connectionString = $"Server={branch.branch_host};Database={branch.branch_db_name};User Id={branch.branch_db_username};Password={branch.branch_db_password};TrustServerCertificate=True;";

        var optionsBuilder = new DbContextOptionsBuilder<BranchDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new BranchDbContext(optionsBuilder.Options);
    }
}
