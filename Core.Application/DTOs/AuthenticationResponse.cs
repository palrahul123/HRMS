using System.Text.Json.Serialization;

namespace Core.Application.DTOs
{
    public class AuthenticationResponse
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("isEmployee")]
        public bool IsEmployee { get; set; }

        [JsonPropertyName("companyId")]
        public int CompanyId { get; set; }

        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }

        [JsonPropertyName("branchId")]
        public int BranchId { get; set; }

        [JsonPropertyName("branchName")]
        public string BranchName { get; set; }

        [JsonPropertyName("roleId")]
        public int? RoleId { get; set; }

        [JsonPropertyName("roleName")]
        public string RoleName { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
