using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Commands.Update;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Queries.GetAll;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Queries.GetDetails;
using HR.LeaveManagement.Application.Features.LeaveType.Commands.Create;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.MappingProfiles
{
    public class LeaveAllocationProfile : Profile
    {
        public LeaveAllocationProfile()
        {
            CreateMap<LeaveAllocationDto, LeaveAllocation>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDetailsDto>();
            CreateMap<CreateTypeCommand, LeaveAllocation>();
            CreateMap<UpdateAllocationCommand, LeaveAllocation>();
        }
    }
}
