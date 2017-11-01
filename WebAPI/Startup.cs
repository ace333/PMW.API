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
using WebAPI.Context;
using Microsoft.EntityFrameworkCore;
using WebAPI.Abstraction;
using WebAPI.Model;
using WebAPI.Repositories;

namespace WebAPI
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

            //services.AddDbContext<EFContext>(x => x.UseSqlServer(Configuration.GetConnectionString("MSQL")));
            services.AddDbContext<EFContext>(x => x.UseNpgsql(Configuration.GetConnectionString("PSQL")));

            services.AddTransient(typeof(IEFDbContext), typeof(EFContext));
            services.AddTransient(typeof(IHeartRate), typeof(HeartRate));
            services.AddTransient(typeof(IHeartRateRepository), typeof(HeartRateRepository));
            services.AddTransient(typeof(IAccelero), typeof(Accelero));
            services.AddTransient(typeof(IAcceleroRepository), typeof(AcceleroRepository));
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
