namespace Core.Application.DTOs.BranchDtos
{
    public class CreateBranchDto
    {
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string Area { get; set; }

        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }

        public int CompanyId { get; set; }
    }
}
