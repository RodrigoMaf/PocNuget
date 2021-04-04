using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PocNugetSL.Configuration;
using PocNugetSL.Features.FeatureOne;
using PocNugetSL.Interfaces.FeatureOne;

namespace PocNugetSL.Register
{
    /// <summary>Register feature one</summary>
    internal static class RegisterFeatureOne
    {
        /// <summary>Configure Feature one to use</summary>
        /// <param name="services">Dependency Injection</param>
        /// <param name="configuration">Configuration data</param>
        internal static IServiceCollection ConfigureFeatureOne(this IServiceCollection services, IConfiguration configuration)
            => services
                .ConfigureData(configuration)
                .AddSingleton<IFeatureOne, FeatureOne>();

        /// <summary>Configuration data feature one</summary>
        /// <param name="services">Dependency Injection</param>
        /// <param name="configuration">Configuration data</param>
        private static IServiceCollection ConfigureData(this IServiceCollection services, IConfiguration configuration) 
        {
            services
                .AddOptions<ConfigurationFeatureOneData>()
                .Configure(options => {
                    configuration.GetSection("FeatureOne").Bind(options);
                });
            return services;
        }

    }
}