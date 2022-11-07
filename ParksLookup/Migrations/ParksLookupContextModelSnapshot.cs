﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksLookup.Models;

namespace ParksLookup.Migrations
{
    [DbContext(typeof(ParksLookupContext))]
    partial class ParksLookupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParksLookup.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PointsOfInterest")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("StateOrNational")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Name = "Yellowstone",
                            PointsOfInterest = "Steam Boat Geyser, Old Faithful Geyser Mammoth Hotsprings",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 2,
                            Name = "Yosemite",
                            PointsOfInterest = "Half Dome, Glacier Point, Yosemite Falls",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 3,
                            Name = "Hearst San Simeon",
                            PointsOfInterest = "Hearst Castle, San Simeon Pier, San Simeon Camp Grounds",
                            StateOrNational = "State"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
