﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrailsApi.Models;

namespace Business.Migrations
{
    [DbContext(typeof(TrailsApiContext))]
    partial class TrailsApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TrailsApi.Models.TrailMarker", b =>
                {
                    b.Property<int>("TrailMarkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Latitude")
                        .HasColumnType("int");

                    b.Property<int>("Longitude")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("isLandmark")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("isTrailhead")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("TrailMarkerId");

                    b.ToTable("TrailMarkers");

                    b.HasData(
                        new
                        {
                            TrailMarkerId = 1,
                            Description = "dirt trail off of Springwater",
                            Latitude = 2,
                            Longitude = 1,
                            Name = "Powell Butte Trailhead",
                            isLandmark = false,
                            isTrailhead = true
                        },
                        new
                        {
                            TrailMarkerId = 2,
                            Description = "pond that seasonally has many frogs and frogs sounds",
                            Latitude = 4,
                            Longitude = 3,
                            Name = "Oaks Bottom Frog Pond",
                            isLandmark = true,
                            isTrailhead = false
                        },
                        new
                        {
                            TrailMarkerId = 3,
                            Description = "when you arrive to the lighthouse you have reached end of the trail! Enjoy!",
                            Latitude = 6,
                            Longitude = 5,
                            Name = "Sauvies Island Lighthouse",
                            isLandmark = true,
                            isTrailhead = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}