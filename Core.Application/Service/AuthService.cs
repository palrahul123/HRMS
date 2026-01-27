using AutoMapper;
using Core.Application.DTOs;
using Core.Application.Interface;
using Core.Domain;
using Infrastructure.Persistence.Interfaces;

namespace Core.Application.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtService _jwtService;
        private readonly Mapper _mapper;
        public AuthService(IUserRepository userRepository, JwtService jwtService, Mapper mapper)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
            _mapper = mapper;
        }
        public async Task<AuthenticationResponse> Login(LoginRequestDto login)
        {
            User user = await _userRepository.GetDetailByEmailandPassword(login.Email);
            if (user == null)
            {
                throw new Exception("Invalid email or password.");
            }

            if ("" != login.Password)
                throw new Exception("Invalid email or password");

            string token = _jwtService.GeneratorToken(user);
            var response = _mapper.Map<AuthenticationResponse>(user);
            response.Token = token;
            return response;
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
