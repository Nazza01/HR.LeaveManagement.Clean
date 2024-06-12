using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.Update
{
    public class UpdateTypeCommand : IRequest<Unit>
    {
        private ILeaveAllocationRepository _leaveTypeRepository;

        public UpdateTypeCommand(ILeaveAllocationRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }
    }
}
