using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Commands.Update
{
    public class UpdateAllocationCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
