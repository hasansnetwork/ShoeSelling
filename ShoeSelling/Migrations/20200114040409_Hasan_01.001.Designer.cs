﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoeSelling.Models;

namespace ShoeSelling.Migrations
{
    [DbContext(typeof(ShoesContext))]
    [Migration("20200114040409_Hasan_01.001")]
    partial class Hasan_01001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShoeSelling.Models.Shoe", b =>
                {
                    b.Property<int>("ShoeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeasonID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoeID");

                    b.ToTable("Shoe");
                });

            modelBuilder.Entity("ShoeSelling.Models.ShoesSize", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EuNumber")
                        .HasColumnType("int");

                    b.Property<int>("UkNumber")
                        .HasColumnType("int");

                    b.Property<int>("UsNumber")
                        .HasColumnType("int");

                    b.HasKey("SizeId");

                    b.ToTable("ShoesSize");
                });

            modelBuilder.Entity("ShoeSelling.Models.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("SizeId");

                    b.ToTable("Size");
                });
#pragma warning restore 612, 618
        }
    }
}