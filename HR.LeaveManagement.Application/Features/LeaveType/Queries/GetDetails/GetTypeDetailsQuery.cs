using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetDetails;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public record GetTypeDetailsQuery(int Id) : IRequest<LeaveTypeDetailsDto>;
}
