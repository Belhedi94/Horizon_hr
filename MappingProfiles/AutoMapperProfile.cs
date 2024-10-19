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
using Horizon_HR.Dtos.DocumentRequest;

namespace Horizon_HR.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.EmploymentDetails, opt => opt.MapFrom(src => src.EmploymentDetails))
                .ForMember(dest => dest.BankAccount, opt => opt.MapFrom(src => src.BankAccount));
            CreateMap<UserDto, User>();
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
            CreateMap<EmploymentDetailsDto, EmploymentDetails>();
            CreateMap<EmploymentDetailsCreationDto, EmploymentDetails>();
            CreateMap<EmploymentDetailsUpdateDto, EmploymentDetails>();

            CreateMap<BankAccount, BankAccountDto>();
            CreateMap<BankAccountDto, BankAccount>();
            CreateMap<CreateBankAccountDto, BankAccount>();
            CreateMap<UpdateBankAccountDto, BankAccount>();

            CreateMap<Team, TeamDto>();
            CreateMap<CreateTeamDto, Team>();
            CreateMap<UpdateTeamDto, Team>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Department, DepartmentDto>();
            CreateMap<CreateDepartmentDto, Department>();
            CreateMap<UpdateDepartmentDto, Department>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Position, PositionDto>();
            CreateMap<CreatePositionDto, Position>();
            CreateMap<UpdatePositionDto, Position>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));


            CreateMap<CreateLeaveRequestDto, LeaveRequest>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());

            CreateMap<LeaveRequest, LeaveRequestDto>();

            CreateMap<UpdateLeaveRequestDto, LeaveRequest>()
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.Now))
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember, destMember) =>
                {
                    // Only map if the source value is not null
                    // For booleans and other value types, you can further refine the condition as needed
                    if (srcMember == null)
                    {
                        return false; // Do not map if the source member is null
                    }

                    // Specifically handle DateTime to prevent overwriting with default values
                    if (srcMember is DateTime date && date == default(DateTime))
                    {
                        return false; // Do not map default DateTime values (0001-01-01)
                    }

                    return true; // Otherwise, allow the mapping
                }));
            //.ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<LeaveBalance, LeaveBalanceDto>();
            CreateMap<LeaveBalance, CreateLeaveBalanceDto>();
            CreateMap<CreateLeaveBalanceDto, LeaveBalance>();
            CreateMap<UpdateLeaveBalanceDto, LeaveBalance>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateDocumentRequestDto, DocumentRequest>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());

            CreateMap<DocumentRequest, DocumentRequestDto>();
            CreateMap<UpdateDocumentRequestDto, DocumentRequest>();


        }
    }
}
