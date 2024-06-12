using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Queries.GetAll
{
    public class GetAllAllocationsQuery : IRequest<List<LeaveAllocationDto>>
    {

    }
}
