﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POPOST.Models;

#nullable disable

namespace POPOST.Migrations
{
    [DbContext(typeof(BoxDbContext))]
    [Migration("20240223103424_UpdateBike")]
    partial class UpdateBike
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("POPOST.Models.Bike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("isLocked")
                        .HasColumnType("bit");

                    b.Property<bool>("isUsed")
                        .HasColumnType("bit");

                    b.Property<int>("useCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bike");
                });

            modelBuilder.Entity("POPOST.Models.Box", b =>
                {
                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Date");

                    b.ToTable("Box");
                });
#pragma warning restore 612, 618
        }
    }
}