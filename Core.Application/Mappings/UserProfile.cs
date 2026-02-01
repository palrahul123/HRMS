using AutoMapper;
using Core.Application.DTOs.UserProfile;
using Core.Domain;

namespace Core.Application.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, User>()
                 .ForMember(dest => dest.Id, opt => opt.Ignore())
                 .ForMember(dest => dest.DocumentUploads, opt => opt.Ignore())
                 .ForMember(dest => dest.EmployeeBankAccounts, opt => opt.Ignore())
                 .ForMember(dest => dest.userRoles, opt => opt.Ignore())
                 .ForMember(dest => dest.Company, opt => opt.Ignore())
                 .ForMember(dest => dest.Branch, opt => opt.Ignore());


            CreateMap<UpdateUserDto, User>()
                .ForMember(dest => dest.DocumentUploads, opt => opt.Ignore())
                .ForMember(dest => dest.EmployeeBankAccounts, opt => opt.Ignore())
                .ForMember(dest => dest.userRoles, opt => opt.Ignore())
                .ForMember(dest => dest.Company, opt => opt.Ignore())
                .ForMember(dest => dest.Branch, opt => opt.Ignore());


            CreateMap<User, UserResponseDto>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company != null ? src.Company.CompanyName : null))
                .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.Branch != null ? src.Branch.BranchName : null));

            CreateMap<User, AuthenticationResponse>()
               .ForMember(dest => dest.CompanyId, opt => opt.MapFrom(src => src.CompanyId ?? 0))
               .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company != null ? src.Company.CompanyName : string.Empty))
               .ForMember(dest => dest.BranchId, opt => opt.MapFrom(src => src.BranchId ?? 0))
               .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.Branch != null ? src.Branch.BranchName : string.Empty))
               .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.RoleId))
               .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.userRoles != null && src.userRoles.Any() ? src.userRoles.FirstOrDefault().Role.RoleName : string.Empty))
               .ForMember(dest => dest.Token, opt => opt.Ignore())
               .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
               .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
               .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
               .ForMember(dest => dest.IsEmployee, opt => opt.MapFrom(src => src.IsEmployee));

        }
    }
}
