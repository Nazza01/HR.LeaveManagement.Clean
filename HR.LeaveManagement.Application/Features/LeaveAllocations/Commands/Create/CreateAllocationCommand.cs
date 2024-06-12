using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;

public class CreateAllocationCommand : IRequest<Unit>
{
    public int LeaveTypeId { get; set; }
}