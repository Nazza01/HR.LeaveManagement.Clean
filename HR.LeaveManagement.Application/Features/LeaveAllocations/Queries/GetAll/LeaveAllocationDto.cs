using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAll;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Queries.GetAll
{
    public class LeaveAllocationDto
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
