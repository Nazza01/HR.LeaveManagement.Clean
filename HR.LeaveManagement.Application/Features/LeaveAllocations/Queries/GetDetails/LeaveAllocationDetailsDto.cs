using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAll;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Queries.GetDetails
{
    public class LeaveAllocationDetailsDto
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
