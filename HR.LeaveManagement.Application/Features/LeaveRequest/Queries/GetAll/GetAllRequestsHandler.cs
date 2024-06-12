using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Logging;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Queries.GetAll
{
    public class GetAllRequestsHandler : IRequestHandler<GetAllRequestsQuery, List<LeaveRequestDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetAllRequestsHandler> _logger;

        public GetAllRequestsHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
        }

        public async Task<List<LeaveRequestDto>> Handle(GetAllRequestsQuery request, CancellationToken cancellationToken)
        {
            // Check if the current user is a logged in employee
            var leaveRequests = await _leaveRequestRepository.GetLeaveRequestWithDetails();
            var requests = _mapper.Map<List<LeaveRequestDto>>(leaveRequests);

            // Fill requests with employee information


            return requests;
        }
    }
}
