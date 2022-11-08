using System.Runtime.CompilerServices;

namespace BlazorFreeCodeCamp.Services.ConfigureServices
{
    // 3) We register service into the service container
    public static class ConfigureServices
    {
        public static IServiceCollection AddFrontEndServices(this IServiceCollection service)
        {
            // Server-Side

            // AddSingleton     - creates one and only instance for the whole application
            // AddTransient     - creates new instance everytime we inject it
            // AddScoped        - creates new instance for every request (survives navigating away and back, but not Refresh which disconects the SignalR
            //                    connection and reestablishes it again, the instance lives as long as the connection is open

            // Blazor Web Assmebly - doesn't have a scoped lifetime management configuration, it will work as a singleton,
            //                     - because if we refresh the browser it will download the whole aplication again

            // AddSingleton     - creates one and only instance for the whole application
            // AddTransient     - creates new instance everytime we inject it
            // AddScoped        - behaves like singleton in this case

            service.AddTransient<IPersonService, PersonService>();
            // service.AddScoped<IPersonService, PersonService>();
            // services.AddSingleton<IPersonService, PersonService>();
            return service;
        }
    }
}
