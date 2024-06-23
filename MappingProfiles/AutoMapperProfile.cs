using AutoMapper;
using Horizon_HR.Contracts.EmploymentDetails;
using Horizon_HR.Contracts.Users;
using Horizon_HR.Contracts.Teams;
using Horizon_HR.Models;
using Horizon_HR.Contracts.Departments;
using Horizon_HR.Contracts.Positions;

namespace Horizon_HR.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, UserDto>();
            CreateMap<CreateUserDto, User>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.Password, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordSalt, opt => opt.Ignore());

            CreateMap<UpdateUserDto, User>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.Password, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordSalt, opt => opt.Ignore())
                .ForMember(dest => dest.Cv, opt => opt.Ignore())
                .ForMember(dest => dest.ProfileImage, opt => opt.Ignore())
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<EmploymentDetailsCreationDto, EmploymentDetails>();

            CreateMap<Team, TeamDto>();
            CreateMap<CreateTeamDto, Team>();
            CreateMap<UpdateTeamDto, Team>();

            CreateMap<Department, DepartmentDto>();
            CreateMap<CreateDepartmentDto, Department>();
            CreateMap<UpdateDepartmentDto, Department>();

            CreateMap<Position, PositionDto>();
            CreateMap<CreatePositionDto, Position>();
            CreateMap<UpdatePositionDto, Position>();


        }
    }
}
