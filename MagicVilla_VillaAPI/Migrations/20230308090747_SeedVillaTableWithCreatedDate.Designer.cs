﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230308090747_SeedVillaTableWithCreatedDate")]
    partial class SeedVillaTableWithCreatedDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbRoom")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Superficie")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_date = new DateTime(2023, 3, 8, 10, 7, 46, 854, DateTimeKind.Local).AddTicks(6863),
                            Description = "vaste",
                            ImageUrl = "https://cdn.pixabay.com/photo/2016/06/24/10/47/house-1477041_960_720.jpg",
                            Name = "bangalo",
                            NbRoom = 2,
                            Rate = 1.0,
                            Superficie = 15,
                            Updated_date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Created_date = new DateTime(2023, 3, 8, 10, 7, 46, 854, DateTimeKind.Local).AddTicks(6882),
                            Description = "beau",
                            ImageUrl = "https://pixabay.com/photos/lost-places-villa-ruins-abandoned-2759275/",
                            Name = "maison",
                            NbRoom = 3,
                            Rate = 1.0,
                            Superficie = 20,
                            Updated_date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Created_date = new DateTime(2023, 3, 8, 10, 7, 46, 854, DateTimeKind.Local).AddTicks(6884),
                            Description = "grand",
                            ImageUrl = "https://pixabay.com/photos/lost-places-villa-ruins-abandoned-2759275/",
                            Name = "s+3",
                            NbRoom = 5,
                            Rate = 1.0,
                            Superficie = 180,
                            Updated_date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
