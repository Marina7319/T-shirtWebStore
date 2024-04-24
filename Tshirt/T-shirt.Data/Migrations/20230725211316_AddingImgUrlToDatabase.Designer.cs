﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using T_shirt.Data.Data;

#nullable disable

namespace T_shirt.Data.Migrations
{
    [DbContext(typeof(TshirtStoreDbContext))]
    [Migration("20230725211316_AddingImgUrlToDatabase")]
    partial class AddingImgUrlToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("T_shirt.Models.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("T_shirt.Models.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TshirtName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Color = "Green",
                            Description = "High quality printed t-shirt. Made of 100% cotton, soft and comfortable to wear. DTG printing of the prints - they don't stay like patches, they don't peel and they don't crack. Free customization. Inspection included upon delivery. ",
                            ImageUrl = "",
                            ListPrice = 28.0,
                            Size = "XL",
                            TshirtName = "Men T-shirt Awesome Since 1982"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Color = "Black",
                            Description = "If you're a fan of the hilarious sitcom Friends, then you'll love this cool t-shirt from Plastic Head. It has a wonderful design that is inspired by iconic elements associated with the beloved series. The series, which follows the six inseparable friends, has become one of the most loved comedy series of all time. The sitcom follows their daily lives, the development of their relationships, their professional and personal lives, with a mixture of joys and disappointments.\r\n\r\nThe t-shirt is unisex and made of cotton. It is soft, comfortable and available in different sizes. The t-shirt is officially licensed and will become a great addition to any Friends collection and wardrobe.\r\n\r\n",
                            ImageUrl = "",
                            ListPrice = 19.0,
                            Size = "XXL",
                            TshirtName = "T-shirt Plastic Head Television: Friends - Icons"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Color = "Pink, White",
                            Description = "",
                            ImageUrl = "",
                            ListPrice = 23.0,
                            Size = "L",
                            TshirtName = "Lola Bunny Dreams Women's T-Shirt* DTG"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Color = "pink, Yellow",
                            Description = "High quality printed t-shirt. Made of 100% cotton, soft and comfortable to wear. DTG printing of the prints - they don't stay like patches, they don't peel and they don't crack. Free customization. Inspection included upon delivery. ",
                            ImageUrl = "",
                            ListPrice = 23.0,
                            Size = "L",
                            TshirtName = "Women's Butterfly 2022 DTG T-Shirt"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Color = "Black",
                            Description = "Men's T-Shirt The Game (Squid Game)\r\nThe newest addition to our series fan t-shirts collection!",
                            ImageUrl = "",
                            ListPrice = 28.0,
                            Size = "XS",
                            TshirtName = "Men's T-Shirt The Game (Squid Game)"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Color = "White",
                            Description = "",
                            ImageUrl = "",
                            ListPrice = 23.0,
                            Size = "S",
                            TshirtName = "Women's Powerpuff Girls / Buttercup DTG T-Shirt"
                        });
                });

            modelBuilder.Entity("T_shirt.Models.Models.Product", b =>
                {
                    b.HasOne("T_shirt.Models.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
