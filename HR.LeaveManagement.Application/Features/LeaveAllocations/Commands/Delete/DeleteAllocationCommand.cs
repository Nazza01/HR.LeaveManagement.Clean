using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Commands.Delete
{
    public class DeleteAllocationCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}