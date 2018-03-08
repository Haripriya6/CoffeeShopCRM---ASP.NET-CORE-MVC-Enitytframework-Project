using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CS_CustomerInfo_Module.Migrations
{
    public partial class AddCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cust_Addr1 = table.Column<string>(nullable: true),
                    Cust_Addr2 = table.Column<string>(nullable: true),
                    Cust_City = table.Column<string>(nullable: true),
                    Cust_ContactNumber = table.Column<string>(nullable: false),
                    Cust_Country = table.Column<string>(nullable: true),
                    Cust_Email = table.Column<string>(nullable: true),
                    Cust_FirstName = table.Column<string>(nullable: false),
                    Cust_LastName = table.Column<string>(nullable: true),
                    Cust_ProvinceState = table.Column<string>(nullable: true),
                    Cust_Website = table.Column<string>(nullable: true),
                    Cust_ZipPostalCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
