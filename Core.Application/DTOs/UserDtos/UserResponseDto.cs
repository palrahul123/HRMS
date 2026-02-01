using static Core.Domain.Enums;

namespace Core.Application.DTOs.UserProfile
{
    public class UserResponseDto
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool IsEmployee { get; set; }
        public string? CompanyName { get; set; }
        public string? BranchName { get; set; }
        public SalaryTypeEnum SalaryType { get; set; }
        public bool IsBankSalary { get; set; }
    }
}
