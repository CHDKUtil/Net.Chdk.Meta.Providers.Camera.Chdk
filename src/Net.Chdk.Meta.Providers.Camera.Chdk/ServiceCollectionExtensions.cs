using Microsoft.Extensions.DependencyInjection;
using Net.Chdk.Meta.Providers.Camera.Ps;

namespace Net.Chdk.Meta.Providers.Camera.Chdk
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddChdkProviders(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddPsCameraProviders()
                .AddSingleton<IAltProvider, ChdkAltProvider>()
                .AddSingleton<ICameraPlatformProvider, ChdkCameraPlatformProvider>()
                .AddSingleton<IRevisionProvider, ChdkRevisionProvider>()
                .AddSingleton<ICameraValidator, ChdkCameraValidator>()
                .AddSingleton<ICameraModelValidator, ChdkCameraModelValidator>();
        }
    }
}
