using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.Cancel
{
    public class CancelRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
