using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace EdifyMe.Core.WebApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore().AddCors()
                .AddAuthorization()
                .AddJsonFormatters();

            services.AddAuthentication("Bearer").AddIdentityServerAuthentication(options =>
            {
                options.Authority = "http://localhost:1008";
                options.RequireHttpsMetadata = false;
                options.ApiName = "edify.me.core";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseCors(policy =>
            {
                policy.AllowAnyHeader();
                policy.AllowAnyMethod();
                policy.AllowCredentials();
                //policy.AllowAnyOrigin();
                //System.Text.RegularExpressions.Regex.Split(System.IO.File.ReadAllText("Assets/SpecifiedOrigins.txt")
                //    , "\r\n"
                //    , System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                //    .ToList().ForEach((item) =>
                //    {
                //        policy.WithOrigins(item);
                //    });
                policy.AllowAnyOrigin();
                //policy.WithOrigins("http://localhost:1010");
                //policy.WithOrigins("http://localhost:8080");
            });
            app.UseMvc();
        }
    }
}
