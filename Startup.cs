using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.sun.tools.corba.se.logutil;
using Giphy_Lib.Giphy;
using Giphy_Lib.Services;
using Printful_Library.Services;
using Printful_Library.Printful;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ashley_MockUp_Store.Models;

namespace Ashley_MockUp_Store
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
            services.AddControllersWithViews();
            //05-09-2020 Added next two lines per textbook 20486D - Developing ASP.NET Core MVC Web Applications - Module 13 Implementing Web APIs - Lesson 3
            //05-11-2020 Another note from the Resource 1 Youtube video, this method adds all of the MVC framework dependencies into the project
            services.AddMvc(option => option.EnableEndpointRouting = false);
            //05-12-2020 Adding this to the ConfigureServices to enter the Giphylibrary inside
            services.AddSingleton<IGiphyServices, Giphy_Lib.Services.GiphyServices>();
            services.AddSingleton<IGetRandomGif, GetRandomGif>();
            services.AddSingleton<IPrintfulServices, PrintfulServices>();
            services.AddSingleton<IGetInventory, GetInventory>();
            services.AddSingleton<IGetProductInfo, GetProductInfo>();
            services.AddSingleton<IFrontPageViewModel, FrontPageViewModel>();
            //End 05-15-2-2020 
            services.AddHttpClient();

            
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

            app.UseMvc(); //05-11-2020 (where the MVS is added to the pipeline-Youtuber Daniel Donbavand)
                          //A note:  warning MVC1005: Using 'UseMvc' to configure MVC is not supported while using Endpoint Routing. To continue using 'UseMvc', please set 'MvcOptions.EnableEndpointRouting = false' inside 'ConfigureServices'.
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }

    }
}
