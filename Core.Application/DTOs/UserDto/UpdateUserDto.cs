using static Core.Domain.Enums;

namespace Core.Application.DTOs.UserProfile
{
    public class UpdateUserDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool IsEmployee { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? RoleId { get; set; }
        public SalaryTypeEnum SalaryType { get; set; }
        public bool IsBankSalary { get; set; }
    }
}
