using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Selfitness.Library.Services;

namespace Selfitness.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSelfitness(this IServiceCollection services)
    {
        services.AddScoped<BaseServiceArgument>();
        services.AddScoped<BaseService>();
        services.AddScoped<AccountService>();

        return services;
    }
}