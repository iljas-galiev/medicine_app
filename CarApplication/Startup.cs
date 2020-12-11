using System;
using System.Linq;
using System.Threading.Tasks;
using CarApplication.Core;
using LinqToDB;
using CarApplication.Model.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WebSocketManager;

namespace CarApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            services.AddWebSocketManager();


            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            app.UseHsts();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseWebSockets();
            app.MapWebSocketManager("/msg", serviceProvider.GetService<SocketService>());

            app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
            app.UseStatusCodePagesWithRedirects("/error/error{0}");
        }
    }
}
