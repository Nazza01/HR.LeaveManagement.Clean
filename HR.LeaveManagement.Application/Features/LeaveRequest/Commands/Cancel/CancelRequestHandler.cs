using HR.LeaveManagement.Application.Contracts.Email;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Application.Models.Email;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.Cancel
{
    public class CancelRequestHandler : IRequestHandler<CancelRequestCommand, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IEmailSender _emailSender;

        public CancelRequestHandler(ILeaveRequestRepository leaveRequestRepository, IEmailSender emailSender)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _emailSender = emailSender;
        }

        public async Task<Unit> Handle(CancelRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetByIdAsync(request.Id);

            if (leaveRequest == null)
                throw new NotFoundException(nameof(leaveRequest), request.Id);

            leaveRequest.Cancelled = true;

            // Re-evaluate the employee's allocations for the leave type

            // Send confirmation email
            var email = new EmailMessage
            {
                To = string.Empty,
                Body = $"Your leave request for {leaveRequest.StartDate:D}" +
                    $" to {leaveRequest.EndDate:D} has been cancelled successfully",
                Subject = "Leave request cancelled"
            };

            await _emailSender.SendEmail(email);
            return Unit.Value;
        }
    }
}
