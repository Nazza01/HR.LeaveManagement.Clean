using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Features.LeaveRequest.Shared;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.Create
{
    public class CreateRequestValidator : AbstractValidator<CreateRequestCommand>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateRequestValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new BaseValidator(_leaveTypeRepository));
        }
    }
}
