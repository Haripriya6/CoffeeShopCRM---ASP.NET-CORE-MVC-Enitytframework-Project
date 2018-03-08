using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CS_CustomerInfo_Module.Models;

namespace CS_CustomerInfo_Module.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CS_CustomerInfo_Module.Models.Customer", b =>
                {
                    b.Property<int>("CustID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cust_Addr1");

                    b.Property<string>("Cust_Addr2");

                    b.Property<string>("Cust_City");

                    b.Property<string>("Cust_ContactNumber");

                    b.Property<string>("Cust_Country");

                    b.Property<string>("Cust_Email");

                    b.Property<string>("Cust_FirstName")
                        .IsRequired();

                    b.Property<string>("Cust_LastName");

                    b.Property<string>("Cust_ProvinceState");

                    b.Property<string>("Cust_Website");

                    b.Property<int>("Cust_ZipPostalCode");

                    b.HasKey("CustID");

                    b.ToTable("Customers");
                });
        }
    }
}
