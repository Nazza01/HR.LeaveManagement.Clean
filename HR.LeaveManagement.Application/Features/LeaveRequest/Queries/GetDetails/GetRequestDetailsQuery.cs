using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Queries.GetDetails
{
    public class GetRequestDetailsQuery() : IRequest<LeaveRequestDetailsDto>
    {
        public int Id { get; set; }
    }
}
