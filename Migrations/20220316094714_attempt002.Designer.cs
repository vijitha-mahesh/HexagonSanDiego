﻿// <auto-generated />
using System;
using HexagonSanDiego.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HexagonSanDiego.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220316094714_attempt002")]
    partial class attempt002
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HexagonSanDiego.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoorNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Admin");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HexagonSanDiego.Models.Amenity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amenities");
                });

            modelBuilder.Entity("HexagonSanDiego.Models.FloorPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bath")
                        .HasColumnType("int");

                    b.Property<string>("Bed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deposit")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SqFeet")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FloorPlans");
                });

            modelBuilder.Entity("HexagonSanDiego.Models.HomePage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AmenitiesText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommunityText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacebookLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FooterText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstergramLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotogalleryText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WelcometoImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WelcometoText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YellpLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomePages");
                });

            modelBuilder.Entity("HexagonSanDiego.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmenityId")
                        .HasColumnType("int");

                    b.Property<int?>("HomePageId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmenityId");

                    b.HasIndex("HomePageId");

                    b.ToTable("images");
                });

            modelBuilder.Entity("HexagonSanDiego.Models.Image", b =>
                {
                    b.HasOne("HexagonSanDiego.Models.Amenity", "Amenity")
                        .WithMany("Images")
                        .HasForeignKey("AmenityId");

                    b.HasOne("HexagonSanDiego.Models.HomePage", "HomePage")
                        .WithMany("Images")
                        .HasForeignKey("HomePageId");

                    b.Navigation("Amenity");

                    b.Navigation("HomePage");
                });

            modelBuilder.Entity("HexagonSanDiego.Models.Amenity", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("HexagonSanDiego.Models.HomePage", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
