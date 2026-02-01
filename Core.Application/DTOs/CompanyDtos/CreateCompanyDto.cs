namespace Core.Application.DTOs.CompanyDtos
{
    public class CreateCompanyDto
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Area { get; set; }

        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }

        public string PinCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
