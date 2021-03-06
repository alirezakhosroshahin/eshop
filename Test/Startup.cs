using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Test.Core.Convertors;
using Test.Core.Services;
using Test.Core.Services.Interface;
using Test.DataLayer.Context;

namespace Test
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
            services.AddRazorPages();
            // services.AddRazorPages(options =>
            // {
            //     options.Conventions.AddPageRoute("/Admin/Index", "");
            // });

            #region data base conection

            services.AddDbContext<TestContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("defaultConnction"));
            });

            #endregion
            
            #region Authentication

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme= CookieAuthenticationDefaults.AuthenticationScheme;

            }).AddCookie(options =>
            {
                options.LoginPath = "/Login";
                options.LogoutPath = "/Logout";
                options.ExpireTimeSpan=TimeSpan.FromMinutes(43200);

            });

            #endregion
            
            #region IOC

            services.AddScoped<IUserServices,UserServices>();
            services.AddScoped<IViewRenderService,RenderViewToString>();
            services.AddScoped<IPermissionService,PermissionService>();
            services.AddScoped<ICourseService,CourseService>();
            services.AddScoped<IOrderService,OrderService>();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                 endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name : "areas",
                    pattern : "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}