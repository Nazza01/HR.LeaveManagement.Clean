using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Queries.GetAll
{
    //public class GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>
    //{
    //}

    public record GetAllRequestsQuery : IRequest<List<LeaveRequestDto>>;
}
