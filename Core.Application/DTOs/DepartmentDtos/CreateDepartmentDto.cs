namespace Core.Application.DTOs.DepartmentDtos
{
    public class CreateDepartmentDto
    {
        public string DepartmentName { get; set; }
        public int BranchId { get; set; }
        public int CompanyId { get; set; }
    }
}
