using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.Change
{
    public class ChangeRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public bool Approved { get; set; }
    }
}
