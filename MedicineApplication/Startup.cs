using System;
using System.Linq;
using LinqToDB;
using MedicineApplication.Core;
using MedicineApplication.Model.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WebSocketManager;

namespace MedicineApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            services.AddWebSocketManager();

            services.AddAuthentication(configureOptions =>
                {
                    configureOptions.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    configureOptions.RequireAuthenticatedSignIn = false;
                })
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/auth/login");
                });

            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseWebSockets();
            app.MapWebSocketManager("/msg", serviceProvider.GetService<SocketService>());


            app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });

            app.Run(async (context) =>
            {
                if (context.Request.Cookies.ContainsKey("user"))
                {
                    context.Request.Cookies.TryGetValue("user", out string user);
                    context.Request.Cookies.TryGetValue("__code", out string code);
                    var userEntity = Db.Dc.GetTable<UserEntity>().FirstOrDefault(u => u.Id == Convert.ToInt32(user));
                    if (userEntity.Id != 0 && code == Core.User.ComputeHash(userEntity.Id.ToString() + userEntity.Salt))
                    {
                        context.Session.SetString("user", userEntity.Id.ToString());
                        context.Session.SetString("user_email", userEntity.Email.ToString());
                        context.Session.SetString("user_salt", userEntity.Salt.ToString());
                    }
                }
            });
        }
    }
}
