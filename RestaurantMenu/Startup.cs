using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestaurantMenu.Models;

namespace RestaurantMenu
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
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddControllersWithViews(); 
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

            app.UseMvc(endpoints =>
            {
                endpoints.MapRoute(
                    name: "default",
                    template: "",
                    defaults: new { controller = "Menu", action = "Meal" }); 
                endpoints.MapRoute(
                     name: "menu",
                     template: "menu/meals",
                     defaults: new { controller = "Menu", action = "Meal" });
                endpoints.MapRoute(
                     name: "menuType",
                     template: "menu/{type}/meals",
                     defaults: new { controller = "Menu", action = "Meal" });
                endpoints.MapRoute(
                     name: "mealCreate",
                     template: "menu/create",
                     defaults: new { controller = "Menu", action = "Create" });
                endpoints.MapRoute(
                     name: "mealInterests",
                     template: "menu/interests",
                     defaults: new { controller = "Menu", action = "Interests" });
                endpoints.MapRoute(
                     name: "mealInterestsType",
                     template: "menu/{type}/interests",
                     defaults: new { controller = "Menu", action = "Interests" });
                endpoints.MapRoute(
                     name: "mealDelete",
                     template: "menu/delete/{id}",
                     defaults: new { controller = "Menu", action = "Delete" });
            });
        }
    }
}
