using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.Delete
{
    public class DeleteCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
