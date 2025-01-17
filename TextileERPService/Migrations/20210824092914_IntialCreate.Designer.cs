﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TextileERPService.Context;

namespace TextileERPService.Migrations
{
    [DbContext(typeof(ERPContext))]
    [Migration("20210824092914_IntialCreate")]
    partial class IntialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TextileERPService.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ActualAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BillNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DiscAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DiscPerc")
                        .HasColumnType("int");

                    b.Property<decimal>("InvoiceAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BillId")
                        .HasName("Id");

                    b.HasIndex("InvoiceId")
                        .IsUnique();

                    b.ToTable("Bill", "Payment");
                });

            modelBuilder.Entity("TextileERPService.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("Country", "Master");
                });

            modelBuilder.Entity("TextileERPService.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId")
                        .HasName("Id");

                    b.ToTable("Customer", "Person");
                });

            modelBuilder.Entity("TextileERPService.Models.Fabric", b =>
                {
                    b.Property<int>("FabricId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("COM")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FabricName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("UOMId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FabricId");

                    b.HasIndex("COM");

                    b.HasIndex("UOMId")
                        .IsUnique();

                    b.ToTable("Fabric", "Master");
                });

            modelBuilder.Entity("TextileERPService.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPartialPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Narration")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InvoiceId")
                        .HasName("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoice", "Transaction");
                });

            modelBuilder.Entity("TextileERPService.Models.InvoiceItem", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("FabricId")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("FabricId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("ÏnvoiceItems", "Transaction");
                });

            modelBuilder.Entity("TextileERPService.Models.UOM", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("UnitId")
                        .HasName("Id");

                    b.ToTable("UOM", "Master");
                });

            modelBuilder.Entity("TextileERPService.Models.Bill", b =>
                {
                    b.HasOne("TextileERPService.Models.Invoice", "Invoice")
                        .WithOne("Bill")
                        .HasForeignKey("TextileERPService.Models.Bill", "InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("TextileERPService.Models.Fabric", b =>
                {
                    b.HasOne("TextileERPService.Models.Country", "Country")
                        .WithMany("Fabric")
                        .HasForeignKey("COM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TextileERPService.Models.UOM", "UOM")
                        .WithOne("Fabric")
                        .HasForeignKey("TextileERPService.Models.Fabric", "UOMId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("UOM");
                });

            modelBuilder.Entity("TextileERPService.Models.Invoice", b =>
                {
                    b.HasOne("TextileERPService.Models.Customer", "Customer")
                        .WithMany("Invoice")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("TextileERPService.Models.InvoiceItem", b =>
                {
                    b.HasOne("TextileERPService.Models.Fabric", "Fabric")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("FabricId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TextileERPService.Models.Invoice", "Invoice")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fabric");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("TextileERPService.Models.Country", b =>
                {
                    b.Navigation("Fabric");
                });

            modelBuilder.Entity("TextileERPService.Models.Customer", b =>
                {
                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("TextileERPService.Models.Fabric", b =>
                {
                    b.Navigation("InvoiceItems");
                });

            modelBuilder.Entity("TextileERPService.Models.Invoice", b =>
                {
                    b.Navigation("Bill");

                    b.Navigation("InvoiceItems");
                });

            modelBuilder.Entity("TextileERPService.Models.UOM", b =>
                {
                    b.Navigation("Fabric");
                });
#pragma warning restore 612, 618
        }
    }
}
