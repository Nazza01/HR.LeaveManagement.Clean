using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.Delete
{
    public class DeleteRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
