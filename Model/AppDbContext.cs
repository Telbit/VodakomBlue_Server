using System;
using Microsoft.EntityFrameworkCore;
using VodakomBlue.Model.Home;
using VodakomBlue.Model.Mobile;

namespace VodakomBlue.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HomeInternet> HomeInternets { get; set; }
        public DbSet<HomeInternetService> HomeInternetServices { get; set; }
        public DbSet<HomePhone> HomePhones { get; set; }
        public DbSet<HomePhoneService> HomePhoneServices { get; set; }
        public DbSet<HomeTV> HomeTVs { get; set; }
        public DbSet<HomeTvService> HomeTvServices { get; set; }
        public DbSet<MobileInternetPackage> MobileInternetPackages { get; set; }
        public DbSet<MobilePhonePackage> MobilePhonePackages { get; set; }
        public DbSet<MobileService> MobileServices { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> option) 
            : base(option)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //modelBuilder.Entity<HomeInternetService>().ToTable("HomeInternetService");
        }
    }
}
