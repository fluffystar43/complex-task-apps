﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RentCarsProject.Models;

namespace RentCarsProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210512123045_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RentCarsProject.Data.bonussystem", b =>
                {
                    b.Property<int>("IDbonussystem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double>("Discountpercent")
                        .HasColumnType("double precision");

                    b.HasKey("IDbonussystem");

                    b.ToTable("bonussystem");
                });

            modelBuilder.Entity("RentCarsProject.Data.car", b =>
                {
                    b.Property<int>("IDCar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ClassCar")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int>("IDlocationcar")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("VINnumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<short>("Yearofmanufacture")
                        .HasColumnType("smallint");

                    b.Property<int?>("locationcarIDlocationcar")
                        .HasColumnType("integer");

                    b.HasKey("IDCar");

                    b.HasIndex("locationcarIDlocationcar");

                    b.ToTable("car");
                });

            modelBuilder.Entity("RentCarsProject.Data.client", b =>
                {
                    b.Property<int>("IDclient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Driverslicense")
                        .HasColumnType("integer");

                    b.Property<string>("Familyname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("IDbonussystem")
                        .HasColumnType("integer");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Numberofphone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("Passportdata")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("bonussystemIDbonussystem")
                        .HasColumnType("integer");

                    b.HasKey("IDclient");

                    b.HasIndex("bonussystemIDbonussystem");

                    b.ToTable("client");
                });

            modelBuilder.Entity("RentCarsProject.Data.fine", b =>
                {
                    b.Property<int>("IDfine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("Datefine")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("character varying(70)");

                    b.Property<int>("IDclient")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int?>("clientIDclient")
                        .HasColumnType("integer");

                    b.HasKey("IDfine");

                    b.HasIndex("clientIDclient");

                    b.ToTable("fine");
                });

            modelBuilder.Entity("RentCarsProject.Data.locationcar", b =>
                {
                    b.Property<int>("IDlocationcar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Terrain")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("IDlocationcar");

                    b.ToTable("locationcar");
                });

            modelBuilder.Entity("RentCarsProject.Data.rate", b =>
                {
                    b.Property<int>("IDrate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("IDcar")
                        .HasColumnType("integer");

                    b.Property<int?>("carIDCar")
                        .HasColumnType("integer");

                    b.HasKey("IDrate");

                    b.HasIndex("carIDCar");

                    b.ToTable("rate");
                });

            modelBuilder.Entity("RentCarsProject.Data.rentcar", b =>
                {
                    b.Property<int>("IDrentcar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("Countdaysrent")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Dateofissue")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("IDcar")
                        .HasColumnType("integer");

                    b.Property<int>("IDclient")
                        .HasColumnType("integer");

                    b.Property<int>("IDrate")
                        .HasColumnType("integer");

                    b.Property<int?>("carIDCar")
                        .HasColumnType("integer");

                    b.Property<int?>("clientIDclient")
                        .HasColumnType("integer");

                    b.Property<int?>("rateIDrate")
                        .HasColumnType("integer");

                    b.HasKey("IDrentcar");

                    b.HasIndex("carIDCar");

                    b.HasIndex("clientIDclient");

                    b.HasIndex("rateIDrate");

                    b.ToTable("rentcar");
                });

            modelBuilder.Entity("RentCarsProject.Data.returncar", b =>
                {
                    b.Property<int>("IDreturncar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("IDcar")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Returndate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("carIDCar")
                        .HasColumnType("integer");

                    b.HasKey("IDreturncar");

                    b.HasIndex("carIDCar");

                    b.ToTable("returncar");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RentCarsProject.Data.car", b =>
                {
                    b.HasOne("RentCarsProject.Data.locationcar", "locationcar")
                        .WithMany("car")
                        .HasForeignKey("locationcarIDlocationcar");

                    b.Navigation("locationcar");
                });

            modelBuilder.Entity("RentCarsProject.Data.client", b =>
                {
                    b.HasOne("RentCarsProject.Data.bonussystem", "bonussystem")
                        .WithMany("client")
                        .HasForeignKey("bonussystemIDbonussystem");

                    b.Navigation("bonussystem");
                });

            modelBuilder.Entity("RentCarsProject.Data.fine", b =>
                {
                    b.HasOne("RentCarsProject.Data.client", "client")
                        .WithMany("fine")
                        .HasForeignKey("clientIDclient");

                    b.Navigation("client");
                });

            modelBuilder.Entity("RentCarsProject.Data.rate", b =>
                {
                    b.HasOne("RentCarsProject.Data.car", "car")
                        .WithMany("rate")
                        .HasForeignKey("carIDCar");

                    b.Navigation("car");
                });

            modelBuilder.Entity("RentCarsProject.Data.rentcar", b =>
                {
                    b.HasOne("RentCarsProject.Data.car", "car")
                        .WithMany("rentcar")
                        .HasForeignKey("carIDCar");

                    b.HasOne("RentCarsProject.Data.client", "client")
                        .WithMany("rentcar")
                        .HasForeignKey("clientIDclient");

                    b.HasOne("RentCarsProject.Data.rate", "rate")
                        .WithMany("rentcar")
                        .HasForeignKey("rateIDrate");

                    b.Navigation("car");

                    b.Navigation("client");

                    b.Navigation("rate");
                });

            modelBuilder.Entity("RentCarsProject.Data.returncar", b =>
                {
                    b.HasOne("RentCarsProject.Data.car", "car")
                        .WithMany("returncar")
                        .HasForeignKey("carIDCar");

                    b.Navigation("car");
                });

            modelBuilder.Entity("RentCarsProject.Data.bonussystem", b =>
                {
                    b.Navigation("client");
                });

            modelBuilder.Entity("RentCarsProject.Data.car", b =>
                {
                    b.Navigation("rate");

                    b.Navigation("rentcar");

                    b.Navigation("returncar");
                });

            modelBuilder.Entity("RentCarsProject.Data.client", b =>
                {
                    b.Navigation("fine");

                    b.Navigation("rentcar");
                });

            modelBuilder.Entity("RentCarsProject.Data.locationcar", b =>
                {
                    b.Navigation("car");
                });

            modelBuilder.Entity("RentCarsProject.Data.rate", b =>
                {
                    b.Navigation("rentcar");
                });
#pragma warning restore 612, 618
        }
    }
}
