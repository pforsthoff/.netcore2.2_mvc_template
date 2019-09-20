using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using aspnetcore_template.ServiceModel.Entities;
using aspnetcore_template.Services;
using Microsoft.AspNetCore.Identity;
using System.IO;
using aspnetcore_template.Data.Repositories;
using AutoMapper;
using System;
using aspnetcore_template.Data;
using aspnetcore_template.ServiceModel.Business;
using aspnetcore_template.Business.Managers;

namespace aspnetcore_template
{
    public class Startup
    {
        public Startup()
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IGreeter, Greeter>();
            services.AddSingleton(provider => Configuration);
            services.AddIdentity<User, IdentityRole>()
               .AddEntityFrameworkStores<CoreDbContext>();
            services.AddEntityFrameworkSqlServer();
            services.AddDbContext<CoreDbContext>(options => options.UseSqlServer(Configuration["database:connection"]));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(IRestaurantManager), typeof(RestaurantManager));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
        public IConfiguration Configuration { get; set; }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IGreeter greeter, IHostingEnvironment env)
        {
            app.UseMvc(ConfigureRoutes);
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Run(async (context) =>
            //{
            //    var greeting = greeter.GetGreeting();
            //    await context.Response.WriteAsync(greeting);
            //});
        }
        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            //Home/Index
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Grid}/{id?}");
            //routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
