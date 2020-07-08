using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace webgentlebookstore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "staticfile")),
            //    RequestPath = "/staticfile"
            //});

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");

            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //       {
            //           await context.Response.WriteAsync("Hello from Staging");
            //           endpoints.MapDefaultControllerRoute();
            //           //if (env.IsDevelopment())
            //           //{
            //           //    await context.Response.WriteAsync("Hello World");

            //           //}
            //           //else if (env.IsProduction())
            //           //{
            //           //    await context.Response.WriteAsync("Hello from Prod");
            //           //}
            //           //else if (env.IsStaging())
            //           //{Hello from Staging
            //           //    await context.Response.WriteAsync("Hello from Staging");
            //           //}

            //           //else
            //           //{
            //           //    await context.Response.WriteAsync(env.EnvironmentName);
            //           //}

            //       });
            //});
        }
    }
}
