﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VodakomBlue.Model;

namespace VodakomBlue.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AddressCustomer", b =>
                {
                    b.Property<int>("AdressesId")
                        .HasColumnType("int");

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.HasKey("AdressesId", "CustomersId");

                    b.HasIndex("CustomersId");

                    b.ToTable("AddressCustomer");
                });

            modelBuilder.Entity("VodakomBlue.Model.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsBillingAddress")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHomeAddress")
                        .HasColumnType("bit");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("VodakomBlue.Model.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SalesmanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SalesmanId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("VodakomBlue.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactPhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("IdCardNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("MothersName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("VodakomBlue.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactPhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeType")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("IdCardNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("MothersName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("VodakomBlue.Model.Home.HomeInternet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DownloadSpeed")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Technology")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("UploadSpeed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HomeInternets");
                });

            modelBuilder.Entity("VodakomBlue.Model.Home.HomeInternetService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("InternetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ContractId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InternetId");

                    b.ToTable("HomeInternetServices");
                });

            modelBuilder.Entity("VodakomBlue.Model.Home.HomePhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TalkMinutes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HomePhones");
                });

            modelBuilder.Entity("VodakomBlue.Model.Home.HomePhoneService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("PhoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ContractId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PhoneId");

                    b.ToTable("HomePhoneServices");
                });

            modelBuilder.Entity("VodakomBlue.Model.Home.HomeTV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HomeTVs");
                });

            modelBuilder.Entity("VodakomBlue.Model.Home.HomeTvService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("TvId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ContractId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TvId");

                    b.ToTable("HomeTvServices");
                });

            modelBuilder.Entity("VodakomBlue.Model.Mobile.MobileInternetPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MobileInternetPackages");
                });

            modelBuilder.Entity("VodakomBlue.Model.Mobile.MobilePhonePackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FreeMinutes")
                        .HasColumnType("int");

                    b.Property<int>("FreeSms")
                        .HasColumnType("int");

                    b.Property<int>("InsideNetwork")
                        .HasColumnType("int");

                    b.Property<int>("MinuteFee")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OutsideNetwork")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MobilePhonePackages");
                });

            modelBuilder.Entity("VodakomBlue.Model.Mobile.MobileService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("MobileInternetPackageId")
                        .HasColumnType("int");

                    b.Property<int?>("MobilePhonePackageId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("MobileInternetPackageId");

                    b.HasIndex("MobilePhonePackageId");

                    b.ToTable("MobileServices");
                });

            modelBuilder.Entity("AddressCustomer", b =>
                {
                    b.HasOne("VodakomBlue.Model.Address", null)
                        .WithMany()
                        .HasForeignKey("AdressesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VodakomBlue.Model.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VodakomBlue.Model.Contract", b =>
                {
                    b.HasOne("VodakomBlue.Model.Customer", "Customer")
                        .WithMany("Contracts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VodakomBlue.Model.Employee", "Salesman")
                        .WithMany()
                        .HasForeignKey("SalesmanId");

                    b.Navigation("Customer");

                    b.Navigation("Salesman");
                });

            modelBuilder.Entity("VodakomBlue.Model.Employee", b =>
                {
                    b.HasOne("VodakomBlue.Model.Address", "Address")
                        .WithOne("Employee")
                        .HasForeignKey("VodakomBlue.Model.Employee", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("VodakomBlue.Model.Home.HomeInternetService", b =>
                {
                    b.HasOne("VodakomBlue.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("VodakomBlue.Model.Contract", "Contract")
                        .WithMany("HomeInternetServices")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VodakomBlue.Model.Customer", "Customer")
                        .WithMany("HomeInternetServices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VodakomBlue.Model.Home.HomeInternet", "Internet")
                        .WithMany()
                        .HasForeignKey("InternetId");

                    b.Navigation("Address");

                    b.Navigation("Contract");

                    b.Navigation("Customer");

                    b.Navigation("Internet");
                });

            modelBuilder.Entity("VodakomBlue.Model.Home.HomePhoneService", b =>
                {
                    b.HasOne("VodakomBlue.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("VodakomBlue.Model.Contract", "Contract")
                        .WithMany("HomePhoneServices")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VodakomBlue.Model.Customer", "Customer")
                        .WithMany("HomePhoneServices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VodakomBlue.Model.Home.HomePhone", "Phone")
                        .WithMany()
                        .HasForeignKey("PhoneId");

                    b.Navigation("Address");

                    b.Navigation("Contract");

                    b.Navigation("Customer");

                    b.Navigation("Phone");
                });

            modelBuilder.Entity("VodakomBlue.Model.Home.HomeTvService", b =>
                {
                    b.HasOne("VodakomBlue.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("VodakomBlue.Model.Contract", "Contract")
                        .WithMany("HomeTvServices")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VodakomBlue.Model.Customer", "Customer")
                        .WithMany("HomeTvServices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VodakomBlue.Model.Home.HomeTV", "Tv")
                        .WithMany()
                        .HasForeignKey("TvId");

                    b.Navigation("Address");

                    b.Navigation("Contract");

                    b.Navigation("Customer");

                    b.Navigation("Tv");
                });

            modelBuilder.Entity("VodakomBlue.Model.Mobile.MobileService", b =>
                {
                    b.HasOne("VodakomBlue.Model.Contract", "Contract")
                        .WithMany("MobileServices")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VodakomBlue.Model.Customer", "Customer")
                        .WithMany("MobileServices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VodakomBlue.Model.Mobile.MobileInternetPackage", "MobileInternetPackage")
                        .WithMany()
                        .HasForeignKey("MobileInternetPackageId");

                    b.HasOne("VodakomBlue.Model.Mobile.MobilePhonePackage", "MobilePhonePackage")
                        .WithMany()
                        .HasForeignKey("MobilePhonePackageId");

                    b.Navigation("Contract");

                    b.Navigation("Customer");

                    b.Navigation("MobileInternetPackage");

                    b.Navigation("MobilePhonePackage");
                });

            modelBuilder.Entity("VodakomBlue.Model.Address", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("VodakomBlue.Model.Contract", b =>
                {
                    b.Navigation("HomeInternetServices");

                    b.Navigation("HomePhoneServices");

                    b.Navigation("HomeTvServices");

                    b.Navigation("MobileServices");
                });

            modelBuilder.Entity("VodakomBlue.Model.Customer", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("HomeInternetServices");

                    b.Navigation("HomePhoneServices");

                    b.Navigation("HomeTvServices");

                    b.Navigation("MobileServices");
                });
#pragma warning restore 612, 618
        }
    }
}
