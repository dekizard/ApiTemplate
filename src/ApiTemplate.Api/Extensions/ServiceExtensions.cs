namespace ApiTemplate.Api.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddControllers();

        return services;
    }
}
