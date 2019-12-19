using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OrchidModel;
using OrchidModel.Interfaces;
using OrchidModel.Repository;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Cors;
using EnableCorsAttribute = System.Web.Http.Cors.EnableCorsAttribute;

namespace OrchidNursery
{
    public class Startup
    {
        private object config;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllers();

            string SQLConnectionString = Configuration["connectionString:OrchidDbConnectionString"];
            services.AddDbContext<MyDbContext>(a => a.UseSqlServer(SQLConnectionString));

            services.AddScoped<IOrchid, OrchidNewRepository>();
            services.AddScoped<ICustomer, CustomerRepositry>();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowMyOrgin",
                builder => builder.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()
                    );
            }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("AllowMyOrgin");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            
        }
       
    }
}
