using AutoMapper;
using Core.Application.DTOs.CompanyDtos;
using Core.Domain;

namespace Core.Application.Mappings
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<CreateCompanyDto, Company>();
            CreateMap<UpdateCompanyDto, Company>();
            CreateMap<Company, CompanyDto>()
                .ForMember(d => d.CountryName, o => o.MapFrom(s => s.Country.Name))
                .ForMember(d => d.StateName, o => o.MapFrom(s => s.State.Name))
                .ForMember(d => d.CityName, o => o.MapFrom(s => s.City.Name));
        }
    }
}
