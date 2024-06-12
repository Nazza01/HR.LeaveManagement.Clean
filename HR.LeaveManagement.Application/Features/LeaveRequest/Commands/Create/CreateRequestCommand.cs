using HR.LeaveManagement.Application.Features.LeaveRequest.Shared;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.Create
{
    public class CreateRequestCommand : Base, IRequest<Unit>
    {
        public string RequestComments { get; set; } = string.Empty;
    }
}
