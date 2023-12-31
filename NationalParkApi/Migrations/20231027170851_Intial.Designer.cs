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
    [Migration("20231027170851_Intial")]
    partial class Intial
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
                        .HasColumnType("longtext");

                    b.Property<string>("StateCode")
                        .HasColumnType("longtext");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("NationalParkId");

                    b.ToTable("NationalParks");
                });
#pragma warning restore 612, 618
        }
    }
}
