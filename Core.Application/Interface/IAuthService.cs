using Core.Application.DTOs;

namespace Core.Application.Interface
{
    public interface IAuthService
    {
        public Task<AuthenticationResponse> Login(LoginRequestDto login);
        public void Logout();
    }
}
