using AutoMapper;
using Core.Application.DTOs.BranchDtos;
using Core.Domain;

namespace Core.Application.Mappings
{
    public class BranchProfile : Profile
    {
        public BranchProfile()
        {
            CreateMap<CreateBranchDto, Branch>();
            CreateMap<UpdateBranchDto, Branch>();

            CreateMap<Branch, BranchDto>()
                .ForMember(d => d.CityName, o => o.MapFrom(s => s.City.Name))
                .ForMember(d => d.StateName, o => o.MapFrom(s => s.State.Name))
                .ForMember(d => d.CountryName, o => o.MapFrom(s => s.Country.Name))
                .ForMember(d => d.CompanyName, o => o.MapFrom(s => s.Company.CompanyName));
        }
    }
}
