﻿// <auto-generated />
using System;
using EntityAssetTracking3;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityAssetTracking3.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityAssetTracking3.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ExchangeRate")
                        .HasColumnType("float");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "MacBook",
                            Currency = "GBP",
                            ExchangeRate = 1.1499999999999999,
                            Model = "Air",
                            Office = "England",
                            Price = 1800.0,
                            PurchaseDate = new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Asus",
                            Currency = "EUR",
                            ExchangeRate = 1.0,
                            Model = "B42",
                            Office = "Spain",
                            Price = 500.0,
                            PurchaseDate = new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Lenovo",
                            Currency = "SEK",
                            ExchangeRate = 0.089999999999999997,
                            Model = "Yoga 9",
                            Office = "Sweden",
                            Price = 6100.0,
                            PurchaseDate = new DateTime(2019, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "HP",
                            Currency = "SEK",
                            ExchangeRate = 0.089999999999999997,
                            Model = "EliteBook",
                            Office = "Sweden",
                            Price = 17600.0,
                            PurchaseDate = new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Iphone",
                            Currency = "SEK",
                            ExchangeRate = 0.089999999999999997,
                            Model = "13 Pro",
                            Office = "Sweden",
                            Price = 13600.0,
                            PurchaseDate = new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Samsung",
                            Currency = "EUR",
                            ExchangeRate = 1.0,
                            Model = "Galaxy",
                            Office = "Spain",
                            Price = 800.0,
                            PurchaseDate = new DateTime(2019, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Nokia",
                            Currency = "SEK",
                            ExchangeRate = 0.089999999999999997,
                            Model = "V Flip",
                            Office = "Sweden",
                            Price = 10300.0,
                            PurchaseDate = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Iphone",
                            Currency = "EUR",
                            ExchangeRate = 1.0,
                            Model = "12 Mini",
                            Office = "Spain",
                            Price = 980.0,
                            PurchaseDate = new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Asus",
                            Currency = "GBP",
                            ExchangeRate = 1.1499999999999999,
                            Model = "X515",
                            Office = "England",
                            Price = 700.0,
                            PurchaseDate = new DateTime(2018, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "Samsung",
                            Currency = "SEK",
                            ExchangeRate = 0.089999999999999997,
                            Model = "Flip2",
                            Office = "Sweden",
                            Price = 9800.0,
                            PurchaseDate = new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}