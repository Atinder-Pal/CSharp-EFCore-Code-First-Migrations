﻿// <auto-generated />
using CodeFirstPractice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstPractice.Migrations
{
    [DbContext(typeof(ShelfContext))]
    [Migration("20201031232236_SeedShelfTable")]
    partial class SeedShelfTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirstPractice.Models.Shelf", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("ID");

                    b.ToTable("Shelf");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            Name = "Work"
                        },
                        new
                        {
                            ID = -2,
                            Name = "Computer"
                        },
                        new
                        {
                            ID = -3,
                            Name = "Kitchen"
                        },
                        new
                        {
                            ID = -4,
                            Name = "DiningRoom"
                        },
                        new
                        {
                            ID = -5,
                            Name = "BedRoom"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
