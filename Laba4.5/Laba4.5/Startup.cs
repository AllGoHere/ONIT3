using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba4._5.Managers.CHnumbers;
using Laba4._5.Managers.Clients;
using Laba4._5.Managers.Hotels;
using Laba4._5.Managers.Numbers;
using Laba4._5.Managers.Personals;
using Laba4._5.Storage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;



namespace Laba4._5
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;
        public Startup (Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("HotelDbSetting.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkId=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HotelDataContext>(options => options.UseSqlServer(_configurationRoot.GetConnectionString("HotelDb")));
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddTransient<ICHnumbersManager, CHnumbersManager>();
            services.AddTransient<INumbersManager, NumbersManager>();
            services.AddTransient<IClientsManager, ClientsManager>();
            services.AddTransient<IHotelsManager, HotelsManager>();
            services.AddTransient<IPersonalsManager, PersonalsManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseRequestLocalization();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Hotel}/{action=ShowHotel}/{Id?}");

            });
        }
    }
}
