using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAll;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Queries.GetAll
{
    public class LeaveRequestDto
    {
        public string RequestingEmployeeId { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? Approved { get; set; }
    }
}