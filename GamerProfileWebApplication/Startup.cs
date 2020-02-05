using GamerProfileWebApplication.Data;
using GamerProfileWebApplication.Hubs;
using GamerProfileWebApplication.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GamerProfileWebApplication
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
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = "Blizzard";
            })
            .AddCookie()
            .AddOAuth("Blizzard", options =>
            {
                options.ClientId = Configuration["Blizzard:ClientId"];
                options.ClientSecret = Configuration["Blizzard:ClientSecret"];
                options.CallbackPath = new PathString("/Diablo/Callback");
                

                options.AuthorizationEndpoint = "https://eu.battle.net/oauth/authorize";
                options.TokenEndpoint = "https://eu.battle.net/oauth/token";
                options.UserInformationEndpoint = "https://eu.battle.net/oauth/userinfo";
                

                options.Events = new OAuthEvents
                {
                    OnCreatingTicket = async context =>
                    {
                        var request = new HttpRequestMessage(HttpMethod.Get, context.Options.UserInformationEndpoint);
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", context.AccessToken);

                        var response = await context.Backchannel.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, context.HttpContext.RequestAborted);
                        response.EnsureSuccessStatusCode();

                        //var user = JObject.Parse(await response.Content.ReadAsStringAsync());

                        //context.RunClaimActions(user);
                    }
                };
            });

                services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddSignalR();
            
            services.AddMvc(options => { }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddDbContext<MvcMovieContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));

            services.Configure<TestApiKeys>(Configuration.GetSection("TestApiKeys"));
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}
