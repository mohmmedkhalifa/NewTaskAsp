using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace NewTask2
{
    public class Startup
    {
        public void ConfigurationServices(IServiceCollection services) { }
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env) {
            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapGet("/",async context => {await context.Response.WriteAsync("Hello World"); }));
      }
    }
}
