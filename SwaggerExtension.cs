using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.IO;
using System.Reflection;

namespace TheQuestBuilder.HeroManager.API.Extensions
{
    public static class SwaggerExtension
    {
        public static IServiceCollection AddSwaggerExtension(this IServiceCollection services)
        {
           return services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "The Quest Builder's Hero Manager Microservice Api",
                    Description = "This service manages all the hero details",
                    Contact = new OpenApiContact
                    {
                        Name = "Danial Horne",
                        Email = "Danial@thequestbuilder.com",
                        Url = new Uri("https://thequestbuilder.com")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT License",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    },
                    Version = "v1"
                });

                //generate the xml docs for swagger
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                c.CustomOperationIds(apiDescription =>
                {
                    return apiDescription.TryGetMethodInfo(out MethodInfo methodInfo) ? methodInfo.Name : null;
                });

            }).AddSwaggerGenNewtonsoftSupport();
        }
    }
}
