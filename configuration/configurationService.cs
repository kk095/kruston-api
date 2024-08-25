using kruston_api.Service;

namespace kruston_api.configuration
{
    public static class configurationService
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<AuthService>();
            return services;
        }

    }
}
