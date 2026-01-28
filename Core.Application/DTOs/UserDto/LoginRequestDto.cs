using System.Text.Json.Serialization;

namespace Core.Application.DTOs.UserProfile
{
    public class LoginRequestDto
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
