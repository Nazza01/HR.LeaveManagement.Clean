using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Queries.GetDetails
{
    public class GetAllocationDetailsQuery : IRequest<LeaveAllocationDetailsDto>
    {
        public int Id { get; set; }
    }
}
