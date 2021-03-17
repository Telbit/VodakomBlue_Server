using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using VodakomBlue.Repositories;
using VodakomBlue.Repositories.Implementations;


namespace VodakomBlue
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
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(600);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
          
            services.AddDbContextPool<DbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("VodakomDb")));

            services.AddScoped<IAddressRepository, AddressRepository>();

            services.AddScoped<IContractRepository, ContractRepository>();

            services.AddScoped<ICustomerRepository, CustomerRepository>();

            services.AddScoped<IHomeInternetRepository, HomeInternetRepository>();

            services.AddScoped<IHomeInternetServiceRepository, HomeInternetServiceRepository>();

            services.AddScoped<IHomePhoneRepository, HomePhoneRepository>();

            services.AddScoped<IHomePhoneServiceRepository, HomePhoneServiceRepository>();

            services.AddScoped<IHomeTVRepository, HomeTVRepository>();

            services.AddScoped<IHomeTvServiceRepository, HomeTvServiceRepository>();

            services.AddScoped<IMobileInternetPackageRepository, MobileInternetPackageRepository>();

            services.AddScoped<IMobilePhonePackageRepository, MobilePhonePackageRepository>();

            services.AddScoped<IMobileServiceRepository, MobileServiceRepository>();

            services.AddControllersWithViews();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
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
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
