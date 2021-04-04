using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PocNugetSL
{
    /// <summary>Register packages features</summary>
    public static class RegisterPocNugetSL
    {
        /// <summary>Configure Feature one to use</summary>
        /// <param name="services">Dependency Injection</param>
        /// <param name="configuration">Configuration data</param>
        public static IServiceCollection ConfigureFeatureOne(this IServiceCollection services, IConfiguration configuration)
            => services
                .ConfigureFeatureOne(configuration);

    }
}
