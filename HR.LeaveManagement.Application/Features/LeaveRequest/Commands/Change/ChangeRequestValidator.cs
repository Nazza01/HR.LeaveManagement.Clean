using FluentValidation;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.Change
{
    public class ChangeRequestValidator : AbstractValidator<ChangeRequestCommand>
    {
        public ChangeRequestValidator()
        {
            RuleFor(p => p.Approved)
                .NotNull()
                .WithMessage("Approval status cannot be null");
        }
    }
}
