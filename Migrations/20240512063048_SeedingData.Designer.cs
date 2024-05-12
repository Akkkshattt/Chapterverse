﻿// <auto-generated />
using Chapterverse.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Chapterverse.Migrations
{
    [DbContext(typeof(ChapterVerseDbContext))]
    [Migration("20240512063048_SeedingData")]
    partial class SeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Chapterverse.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Fiction"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Adventure Fiction"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "Comics"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
