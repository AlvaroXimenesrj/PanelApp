using Globo.ServiceApi.Application;
using Globo.ServiceApi.Application.Facades;
using Globo.ServiceApi.Application.Facades.Interfaces;
using Globo.ServiceApi.Application.Facades.Requests;
using Globo.ServiceApi.Application.Facades.Requests.Interfaces;
using Globo.ServiceApi.Application.Interfaces;
using Globo.ServiceApi.Services;
using Globo.ServiceApi.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Globo.ServiceApi.Configurations
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<IServiceApplication, ServiceApplication>();
            services.AddScoped<IMediaPulseFacade, MediaPulseFacade>();
            services.AddScoped<IRequestOne, MediaPulseRequestOne>();
            services.AddScoped<IRequestTwo, MediaPulseRequestTwo>();
            services.AddScoped<IRequestThree, MediaPulseRequestThree>();
            services.AddScoped<IMediaPulseRestService, MPService>();
        }
    }
}
