using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Piscies.EntreContos.Application;
using Piscies.EntreContos.Application.Interface;
using Piscies.EntreContos.Infrastructure;
using Piscies.EntreContos.Infrastructure.Interface;

namespace Piscies.EntreContos.Facade
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //Application
            services.AddScoped<IWriterApp, WriterApp>();
            services.AddScoped<IChallengeApp, ChallengeApp>();

            //Infrastructure
            services.AddScoped<IWriterInfrastructure, WriterInfrastructure>();
            services.AddScoped<IChallengeInfrastructure, ChallengeInfrastructure>();

            //Configurations
            services.AddSingleton(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
