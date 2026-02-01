using AutoMapper;
using Core.Application.DTOs.RoleDtos;
using Core.Domain;

namespace Core.Application.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<CreateRoleDto, Role>();
            CreateMap<Role, RoleDto>();
        }
    }
}
