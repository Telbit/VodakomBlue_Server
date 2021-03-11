using System;
using Microsoft.EntityFrameworkCore;
using VodakomBlue.Model.Home;
using VodakomBlue.Model.Mobile;

namespace VodakomBlue.Model
{
    public class AppDbContext : DbContext
    {
        DbSet<Address> Addresses { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Contract> Contracts { get; set; }
        DbSet<HomeInternet> HomeInternets { get; set; }
        DbSet<HomeInternetService> HomeInternetServices { get; set; }
        DbSet<HomePhone> HomePhones { get; set; }
        DbSet<HomePhoneService> HomePhoneServices { get; set; }
        DbSet<HomeTV> HomeTVs { get; set; }
        DbSet<HomeTvService> HomeTvServices { get; set; }
        DbSet<MobileInternetPackage> MobileInternetPackages { get; set; }
        DbSet<MobilePhonePackage> MobilePhonePackages { get; set; }
        DbSet<MobileService> MobileServices { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> option) 
            : base(option)
        {
        }
    }
}
