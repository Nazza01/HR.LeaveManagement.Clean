using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Email;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Application.Models.Email;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.Change
{
    public class ChangeRequestHandler : IRequestHandler<ChangeRequestCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public ChangeRequestHandler(
            IMapper mapper,
            IEmailSender emailSender,
            ILeaveRequestRepository leaveRequestRepository,
            ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _emailSender = emailSender;
            _leaveRequestRepository = leaveRequestRepository;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(ChangeRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetByIdAsync(request.Id);

            if (leaveRequest == null)
                throw new NotFoundException(nameof(leaveRequest), request.Id);

            leaveRequest.Approved = request.Approved;
            await _leaveRequestRepository.UpdateAsync(leaveRequest);

            // If request is approved, get and update the emplyoee's allocations

            // Send confirmation email
            var email = new EmailMessage
            {
                To = string.Empty,
                Body = $"The approval status for your leave request from {leaveRequest.StartDate:D}" +
                    $" to {leaveRequest.EndDate:D} has been updated",
                Subject = "Leave Request Approval Status"
            };

            await _emailSender.SendEmail(email);
            return Unit.Value;
        }
    }
}
