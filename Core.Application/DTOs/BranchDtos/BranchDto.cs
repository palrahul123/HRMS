namespace Core.Application.DTOs.BranchDtos
{
    public class BranchDto
    {
        public int Id { get; set; }
        public string BranchName { get; set; }

        public string Address { get; set; }
        public string Area { get; set; }

        public string CityName { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }

        public string CompanyName { get; set; }
    }
}
