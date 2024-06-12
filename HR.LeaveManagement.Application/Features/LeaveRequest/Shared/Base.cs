namespace HR.LeaveManagement.Application.Features.LeaveRequest.Shared
{
    public class Base
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
