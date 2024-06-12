using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetDetails;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public class GetTypeDetailsHandler : IRequestHandler<GetTypeDetailsQuery, LeaveTypeDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveTypeRepository;

        public GetTypeDetailsHandler(IMapper mapper, ILeaveAllocationRepository leaveTypeRepository)
        {
            this._mapper = mapper;
            this._leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<LeaveTypeDetailsDto> Handle(GetTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            // Query the database
            var leaveType = await _leaveTypeRepository.GetByIdAsync(request.Id);

            // Verify the record exists
            if (leaveType == null)
                throw new NotFoundException(nameof(leaveType), request.Id);

            // convert data object to DTO object
            var data = _mapper.Map<LeaveTypeDetailsDto>(leaveType);

            // return DTO object
            return data;
        }
    }
}
