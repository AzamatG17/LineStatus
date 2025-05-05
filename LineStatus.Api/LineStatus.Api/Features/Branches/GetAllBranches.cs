using Carter;
using LineStatus.Api.Interfaces;
using LineStatus.Api.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LineStatus.Api.Features.Branches;

public static class GetAllBranches
{
    public record Query : IRequest<IEnumerable<cds_branch>>;

    public class Handler(IApplicationDbContext context) : IRequestHandler<Query, IEnumerable<cds_branch>>
    {
        private readonly IApplicationDbContext _context = context;

        public async Task<IEnumerable<cds_branch>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _context.cds_branch
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }
    }

    public class EndPoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("api/branches", async (ISender sender) =>
                await sender.Send(new Query()));
        }
    }
}
