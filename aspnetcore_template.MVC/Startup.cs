using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using aspnetcore_template.ServiceModel.Entities;
using Microsoft.AspNetCore.Identity;
using System.IO;
using System.Linq;
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
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc(ConfigureRoutes);
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
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
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                    .CreateScope())
            {
                CoreDbContext context = serviceScope.ServiceProvider.GetService<CoreDbContext>();

                if (!context.Restaurants.Any())
                {
                    context.Restaurants.Add(new Restaurant() { Name = "Carabas", Cuisine = CuisineType.Italian });
                    context.Restaurants.Add(new Restaurant() { Name = "Chipotle", Cuisine = CuisineType.Mexican });
                    context.Restaurants.Add(new Restaurant() { Name = "Garbanzo", Cuisine = CuisineType.MiddleEastern });
                    context.Restaurants.Add(new Restaurant() { Name = "Five Guys", Cuisine = CuisineType.American });
                    context.Restaurants.Add(new Restaurant() { Name = "Saigon Springs", Cuisine = CuisineType.Vietnamese });
                    context.Restaurants.Add(new Restaurant() { Name = "Thai Lilly", Cuisine = CuisineType.Thai });
                    context.Restaurants.Add(new Restaurant() { Name = "Monicas", Cuisine = CuisineType.Mexican });
                    context.Restaurants.Add(new Restaurant() { Name = "Popeyes", Cuisine = CuisineType.American });
                    context.Restaurants.Add(new Restaurant() { Name = "AI", Cuisine = CuisineType.Japaneese });
                    context.Restaurants.Add(new Restaurant() { Name = "ChickFilet", Cuisine = CuisineType.American });
                    context.Restaurants.Add(new Restaurant() { Name = "Grifters", Cuisine = CuisineType.American });

                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
    }
}
