using LineStatus.Api.Interfaces;
using LineStatus.Api.Models.DTOs;
using MediatR;

namespace LineStatus.Api.Features.ETicket;

public static class GetETicketStatus
{
    public record Query(EticketStatusDto EticketStatusDto) : IRequest<object>;

    public class Handler : IRequestHandler<Query, object>
    {
        private readonly IDbContextFactory _dbContextFactory;

        public Handler(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<object> Handle(Query request, CancellationToken cancellationToken)
        {
            var context = await _dbContextFactory.CreateAsync(request.EticketStatusDto.BranchId);

            return await context.Tickets.OrderByDescending(t => t.CreatedAt).Take(10).ToListAsync();
        }
    }
}
