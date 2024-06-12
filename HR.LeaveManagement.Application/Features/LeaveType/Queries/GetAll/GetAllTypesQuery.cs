using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAll
{
    //public class GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>
    //{
    //}

    public record GetAllTypesQuery : IRequest<List<LeaveTypeDto>>;
}
