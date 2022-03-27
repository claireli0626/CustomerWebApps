﻿// <auto-generated />
using CustomerList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerList.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20220327023907_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerList.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenderID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("GenderID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "aj@gmail.com",
                            FirstName = "A",
                            GenderID = "M",
                            LastName = "J"
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "bk@gmail.com",
                            FirstName = "B",
                            GenderID = "F",
                            LastName = "K"
                        },
                        new
                        {
                            CustomerId = 3,
                            Email = "cl@gmail.com",
                            FirstName = "C",
                            GenderID = "F",
                            LastName = "L"
                        },
                        new
                        {
                            CustomerId = 4,
                            Email = "dm@gmail.com",
                            FirstName = "D",
                            GenderID = "I",
                            LastName = "M"
                        },
                        new
                        {
                            CustomerId = 5,
                            Email = "en@gmail.com",
                            FirstName = "E",
                            GenderID = "M",
                            LastName = "N"
                        });
                });

            modelBuilder.Entity("CustomerList.Models.Gender", b =>
                {
                    b.Property<string>("GenderID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderID");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            GenderID = "M",
                            Name = "Male"
                        },
                        new
                        {
                            GenderID = "F",
                            Name = "Famale"
                        },
                        new
                        {
                            GenderID = "I",
                            Name = "Intersex"
                        });
                });

            modelBuilder.Entity("CustomerList.Models.Customer", b =>
                {
                    b.HasOne("CustomerList.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });
#pragma warning restore 612, 618
        }
    }
}