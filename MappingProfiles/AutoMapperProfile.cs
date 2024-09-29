using AutoMapper;
using Horizon_HR.Dtos.EmploymentDetails;
using Horizon_HR.Dtos.Users;
using Horizon_HR.Dtos.Teams;
using Horizon_HR.Models;
using Horizon_HR.Dtos.Departments;
using Horizon_HR.Dtos.Positions;
using Horizon_HR.Dtos.BankAccount;
using Horizon_HR.Dtos.LeaveRequest;
using Horizon_HR.Dtos.LeaveBalance;

namespace Horizon_HR.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.EmploymentDetails, opt => opt.MapFrom(src => src.EmploymentDetails))
                .ForMember(dest => dest.BankAccount, opt => opt.MapFrom(src => src.BankAccount));
            CreateMap<CreateUserDto, User>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());

            CreateMap<UpdateUserDto, User>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.ProfileImage, opt => opt.Ignore())
                .ForMember(dest => dest.EmploymentDetails, opt => opt.MapFrom(src => src.EmploymentDetails))
                .ForMember(dest => dest.BankAccount, opt => opt.MapFrom(src => src.BankAccount))
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));


            CreateMap<EmploymentDetails, EmploymentDetailsDto>();
            CreateMap<EmploymentDetailsCreationDto, EmploymentDetails>();
            CreateMap<EmploymentDetailsUpdateDto, EmploymentDetails>();

            CreateMap<BankAccount, BankAccountDto>();
            CreateMap<CreateBankAccountDto, BankAccount>();
            CreateMap<UpdateBankAccountDto, BankAccount>();

            CreateMap<Team, TeamDto>();
            CreateMap<CreateTeamDto, Team>();
            CreateMap<UpdateTeamDto, Team>();

            CreateMap<Department, DepartmentDto>();
            CreateMap<CreateDepartmentDto, Department>();
            CreateMap<UpdateDepartmentDto, Department>();

            CreateMap<Position, PositionDto>();
            CreateMap<CreatePositionDto, Position>();
            CreateMap<UpdatePositionDto, Position>();


            CreateMap<CreateLeaveRequestDto, LeaveRequest>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());

            CreateMap<LeaveRequest, LeaveRequestDto>();

            CreateMap<UpdateLeaveRequestDto, LeaveRequest>()
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.Now));

            CreateMap<LeaveBalance, CreateLeaveBalanceDto>();
            CreateMap<CreateLeaveBalanceDto, LeaveBalance>();
            CreateMap<UpdateLeaveBalanceDto, LeaveBalance>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));


        }
    }
}
