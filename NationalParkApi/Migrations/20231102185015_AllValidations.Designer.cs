﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParkApi.Models;

#nullable disable

namespace NationalParkApi.Migrations
{
    [DbContext(typeof(NationalParkApiContext))]
    [Migration("20231102185015_AllValidations")]
    partial class AllValidations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NationalParkApi.Models.NationalPark", b =>
                {
                    b.Property<int>("NationalParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("StateCode")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<int>("YearCreated")
                        .HasColumnType("int");

                    b.HasKey("NationalParkId");

                    b.ToTable("NationalParks");

                    b.HasData(
                        new
                        {
                            NationalParkId = 1,
                            Name = "Voyageurs National Park",
                            StateCode = "MN",
                            YearCreated = 1975
                        },
                        new
                        {
                            NationalParkId = 2,
                            Name = "Grand Portage National Monument",
                            StateCode = "MN",
                            YearCreated = 1778
                        },
                        new
                        {
                            NationalParkId = 3,
                            Name = "Crater Lake National Park",
                            StateCode = "OR",
                            YearCreated = 1902
                        },
                        new
                        {
                            NationalParkId = 4,
                            Name = "Mount Rainier National Park",
                            StateCode = "WA",
                            YearCreated = 1899
                        },
                        new
                        {
                            NationalParkId = 5,
                            Name = "North Cascades National Park",
                            StateCode = "WA",
                            YearCreated = 1968
                        },
                        new
                        {
                            NationalParkId = 6,
                            Name = "Olympic National Park",
                            StateCode = "WA",
                            YearCreated = 1938
                        },
                        new
                        {
                            NationalParkId = 7,
                            Name = "Death Valley National Park ",
                            StateCode = "CA",
                            YearCreated = 1994
                        },
                        new
                        {
                            NationalParkId = 8,
                            Name = "Channel Islands National Park",
                            StateCode = "CA",
                            YearCreated = 1980
                        },
                        new
                        {
                            NationalParkId = 9,
                            Name = "Joshua Tree National Park",
                            StateCode = "CA",
                            YearCreated = 1994
                        },
                        new
                        {
                            NationalParkId = 10,
                            Name = "Pinnacles National Park",
                            StateCode = "CA",
                            YearCreated = 2013
                        },
                        new
                        {
                            NationalParkId = 11,
                            Name = "Great Smoky Mountains National Park",
                            StateCode = "TN",
                            YearCreated = 1934
                        },
                        new
                        {
                            NationalParkId = 12,
                            Name = "Kenai Fjords National Park",
                            StateCode = "AK",
                            YearCreated = 1980
                        },
                        new
                        {
                            NationalParkId = 13,
                            Name = "Mesa Verde National Park",
                            StateCode = "CO",
                            YearCreated = 1906
                        },
                        new
                        {
                            NationalParkId = 14,
                            Name = "Rocky Mountain National Park ",
                            StateCode = "CO",
                            YearCreated = 1915
                        },
                        new
                        {
                            NationalParkId = 15,
                            Name = "Glacier National Park",
                            StateCode = "MT",
                            YearCreated = 1910
                        },
                        new
                        {
                            NationalParkId = 16,
                            Name = "Yellowstone National Park",
                            StateCode = "WY",
                            YearCreated = 1872
                        },
                        new
                        {
                            NationalParkId = 17,
                            Name = "Big Bend National Park",
                            StateCode = "TX",
                            YearCreated = 1944
                        },
                        new
                        {
                            NationalParkId = 18,
                            Name = "Guadalupe Mountains National Park ",
                            StateCode = "TX",
                            YearCreated = 1972
                        },
                        new
                        {
                            NationalParkId = 19,
                            Name = "Hawaii Volcanoes National Park",
                            StateCode = "HI",
                            YearCreated = 1916
                        },
                        new
                        {
                            NationalParkId = 20,
                            Name = "Denali National Park",
                            StateCode = "AK",
                            YearCreated = 1917
                        });
                });

            modelBuilder.Entity("NationalParkApi.Models.StatePark", b =>
                {
                    b.Property<int>("StateParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("StateCode")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<int>("YearCreated")
                        .HasColumnType("int");

                    b.HasKey("StateParkId");

                    b.ToTable("StateParks");

                    b.HasData(
                        new
                        {
                            StateParkId = 1,
                            Name = "Custer State Park",
                            StateCode = "SD",
                            YearCreated = 1912
                        },
                        new
                        {
                            StateParkId = 2,
                            Name = "Gulf State Park",
                            StateCode = "AL",
                            YearCreated = 1939
                        },
                        new
                        {
                            StateParkId = 3,
                            Name = "Silver Sands State Park",
                            StateCode = "CT",
                            YearCreated = 1960
                        },
                        new
                        {
                            StateParkId = 4,
                            Name = "Starved Rock State Park",
                            StateCode = "IL",
                            YearCreated = 1911
                        },
                        new
                        {
                            StateParkId = 5,
                            Name = "Chicot State Park",
                            StateCode = "LA",
                            YearCreated = 1939
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
