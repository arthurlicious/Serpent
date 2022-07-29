using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SerpantWebApp.Data;
using Microsoft.AspNetCore.Identity;
using SerpantWebApp.Settings;
using SerpantWebApp.Services;
using SerpantWebApp.Models;
using SerpantWebApp.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace SerpantWebApp
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
            services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizeFolder("/Roles", "TwoFactorEnabled");
            });

            services.AddDbContext<SerpantWebAppContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("SerpantWebAppContext")));

            /* telling identity that we have a user identity that looks like this and we have a role that look like this
             
             after toggling identity which is our DB context class we are using default token provider for generating
            the email
             
            currently using identity user, which comes from the identity framework, which is already defined
            in that data framework, which in turn generates the databasse table through entity framework

            however, we can extend that table to accept and store more user information
             */
            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredUniqueChars = 1;
                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
                // User settings
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
            })
                .AddEntityFrameworkStores<SerpantWebAppContext>()
                // this line of code will give you the email two factor authentication functionality
                .AddDefaultTokenProviders();



            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/AccessDenied";

                /*
                 *  options.Cookie.HttpOnly = true;
                 when set to true, it does not allow cookies to be read with clientside script like JS. This
                would prevent cross site scripting vulnerabilities - attempts to read a cookie and sends it back to attacker

                HttpOnly is a Flag, it tells the browser that the cookie should only be accessed by a server

                 */
                options.Cookie.HttpOnly = true;

                
                /*
                 Options.ExpireTimeSpan = TimeSpan.FromSeconds(30); 

                this sets how the long the cookie is valid for. Default is 14 days. If slidingexpiration is false, 
                user will have to sign back once the 30-sec is up. if slidingexpiration is true, then the cookie
                would be re-issued on any request half way through the ExpiresTimeSpan
                 */
                options.ExpireTimeSpan = TimeSpan.FromSeconds(500);
                options.SlidingExpiration = true;
            });

            services.Configure<SMTPSetting>(Configuration.GetSection("SMTP"));

            // Interface is created for the email service to be shared throughout the application
            services.AddSingleton<IEmailService, EmailService>();

            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, AdditionalUserClaimsPrincipalFactory>();


            // Authorization Handlers
            /*          services.AddSingleton<IAuthorizationHandler, ContactAdministratorsAuthorizationHandler>();

                      services.AddSingleton<IAuthorizationHandler, ContactManagerAuthorizationHandler>();

                      services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, AdditionalUserClaimsPrincipalFactory>();*/


            services.AddAuthorization(options =>
            {
                /*options.AddPolicy("AdminOnly", policy => policy.RequireUserName("arthurchongs@gmail.com"));*/
                /*options.AddPolicy("TwoFactorEnabled", x => x.RequireClaim("amr", "mfa"));*/
                options.AddPolicy("TwoFactorEnabled",
                    x => x.RequireClaim("TwoFactorEnabled", "true")
                );
            });

            
            
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
            });
        }
    }
}
