using Core.Application.Common;
using Core.Application.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Application
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped(typeof(IService<>), typeof(Service<,>));
            services.Configure<JwtSettings>(action =>
            {
                action.Issuer = configuration["JwtSettings:Issuer"];
                action.Audience = configuration["JwtSettings:Audience"];
                action.SecretKey = configuration["JwtSettings:SecretKey"];
                action.ExpiryMinutes = Convert.ToInt32(configuration["JwtSettings:ExpirationInMinutes"]);
            });
            services.AddSingleton<JwtService>();
            return services;
        }
    }
}


