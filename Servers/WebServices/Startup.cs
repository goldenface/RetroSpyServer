using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using SoapCore;
using Models;

namespace WebServices
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddMvc(x => x.EnableEndpointRouting = false);
            services.AddSoapCore();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseSoapEndpoint<IAuthenticationService>("/AuthService/AuthService.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);

            app.UseMvc();
        }
    }
}