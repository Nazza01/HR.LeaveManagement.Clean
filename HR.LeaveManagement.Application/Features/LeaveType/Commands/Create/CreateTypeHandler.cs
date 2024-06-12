using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Exceptions;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.Create
{
    public class CreateTypeHandler : IRequestHandler<CreateTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateTypeHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<int> Handle(CreateTypeCommand request, CancellationToken cancellationToken)
        {
            // Validate incoming data
            var validator = new CreateTypeValidator(_leaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Invalid leave type", validationResult);
            }

            // Convert to domain entity object
            var leaveTypeToCreate = _mapper.Map<Domain.LeaveType>(request);

            // Add to Database
            await _leaveTypeRepository.CreateAsync(leaveTypeToCreate);

            // Return record ID
            return leaveTypeToCreate.Id;
        }
    }
}
