using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VodakomBlue.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCardNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MothersName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeInternets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DownloadSpeed = table.Column<int>(type: "int", nullable: false),
                    UploadSpeed = table.Column<int>(type: "int", nullable: false),
                    Technology = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeInternets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePhones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TalkMinutes = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePhones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeTVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeTVs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileInternetPackages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileInternetPackages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobilePhonePackages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreeMinutes = table.Column<int>(type: "int", nullable: false),
                    FreeSms = table.Column<int>(type: "int", nullable: false),
                    MinuteFee = table.Column<int>(type: "int", nullable: false),
                    InsideNetwork = table.Column<int>(type: "int", nullable: false),
                    OutsideNetwork = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobilePhonePackages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZipCode = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsBillingAddress = table.Column<bool>(type: "bit", nullable: false),
                    IsHomeAddress = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    EmployeeType = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCardNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MothersName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesmanId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Employees_SalesmanId",
                        column: x => x.SalesmanId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternetId = table.Column<int>(type: "int", nullable: true),
                    HomeInternetService_AddressId = table.Column<int>(type: "int", nullable: true),
                    PhoneId = table.Column<int>(type: "int", nullable: true),
                    HomePhoneService_AddressId = table.Column<int>(type: "int", nullable: true),
                    TvId = table.Column<int>(type: "int", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    MobilePhonePackageId = table.Column<int>(type: "int", nullable: true),
                    MobileInternetPackageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_Addresses_HomeInternetService_AddressId",
                        column: x => x.HomeInternetService_AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_Addresses_HomePhoneService_AddressId",
                        column: x => x.HomePhoneService_AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_HomeInternets_InternetId",
                        column: x => x.InternetId,
                        principalTable: "HomeInternets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_HomePhones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "HomePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_HomeTVs_TvId",
                        column: x => x.TvId,
                        principalTable: "HomeTVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_MobileInternetPackages_MobileInternetPackageId",
                        column: x => x.MobileInternetPackageId,
                        principalTable: "MobileInternetPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_MobilePhonePackages_MobilePhonePackageId",
                        column: x => x.MobilePhonePackageId,
                        principalTable: "MobilePhonePackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CustomerId",
                table: "Contracts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_SalesmanId",
                table: "Contracts",
                column: "SalesmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AddressId",
                table: "Employees",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_AddressId",
                table: "Service",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ContractId",
                table: "Service",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_CustomerId",
                table: "Service",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_HomeInternetService_AddressId",
                table: "Service",
                column: "HomeInternetService_AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_HomePhoneService_AddressId",
                table: "Service",
                column: "HomePhoneService_AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_InternetId",
                table: "Service",
                column: "InternetId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_MobileInternetPackageId",
                table: "Service",
                column: "MobileInternetPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_MobilePhonePackageId",
                table: "Service",
                column: "MobilePhonePackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_PhoneId",
                table: "Service",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_TvId",
                table: "Service",
                column: "TvId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "HomeInternets");

            migrationBuilder.DropTable(
                name: "HomePhones");

            migrationBuilder.DropTable(
                name: "HomeTVs");

            migrationBuilder.DropTable(
                name: "MobileInternetPackages");

            migrationBuilder.DropTable(
                name: "MobilePhonePackages");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
