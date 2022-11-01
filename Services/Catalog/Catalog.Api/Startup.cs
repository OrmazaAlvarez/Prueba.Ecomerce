using Catalog.Persistence.DataBase;
using Catalog.Service.Queries;
using HealthChecks.UI.Client;
using MediatR;
using Common.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace Catalog.Api
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
            services.AddDbContext<ApplicationDbContext>(options => 
                                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddHealthChecks()
                        .AddDbContextCheck<ApplicationDbContext>();
            services.AddMediatR(Assembly.Load("Catalog.Service.EventHandlers"));
            services.AddTransient<IProductQueryService, ProductQueryService>();
            services.AddTransient<IStockQueryService, StockQueryService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            } //else {
            loggerFactory.AddSyslog(Configuration.GetValue<string>("Papertrail:host"), Configuration.GetValue<int>("Papertrail:port"));
            //}

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("/hc",new HealthCheckOptions() { 
                    Predicate = _ => true,
                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                });
                endpoints.MapControllers();
            });
        }
    }
}
