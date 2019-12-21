﻿// <auto-generated />
using ChangeManager.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChangeManager.Infra.Data.Migrations
{
    [DbContext(typeof(ChangeManagerContext))]
    [Migration("20191221190443_RegisterSeed")]
    partial class RegisterSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ChangeManager.Domain.Entities.Coin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<uint>("Value")
                        .HasColumnName("value")
                        .HasColumnType("int unsigned");

                    b.HasKey("Id");

                    b.HasAlternateKey("Value")
                        .HasName("coin_value_key");

                    b.ToTable("coin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Value = 1u
                        },
                        new
                        {
                            Id = 2,
                            Value = 5u
                        },
                        new
                        {
                            Id = 3,
                            Value = 10u
                        },
                        new
                        {
                            Id = 4,
                            Value = 25u
                        },
                        new
                        {
                            Id = 5,
                            Value = 50u
                        },
                        new
                        {
                            Id = 6,
                            Value = 100u
                        },
                        new
                        {
                            Id = 7,
                            Value = 200u
                        },
                        new
                        {
                            Id = 8,
                            Value = 500u
                        },
                        new
                        {
                            Id = 9,
                            Value = 1000u
                        },
                        new
                        {
                            Id = 10,
                            Value = 2000u
                        },
                        new
                        {
                            Id = 11,
                            Value = 5000u
                        },
                        new
                        {
                            Id = 12,
                            Value = 10000u
                        });
                });

            modelBuilder.Entity("ChangeManager.Domain.Entities.Register", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("register");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Box 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Box 2"
                        });
                });

            modelBuilder.Entity("ChangeManager.Domain.Entities.RegisterCoin", b =>
                {
                    b.Property<int>("RegisterId")
                        .HasColumnType("int");

                    b.Property<int>("CoinId")
                        .HasColumnType("int");

                    b.Property<uint>("Quantity")
                        .HasColumnName("quantity")
                        .HasColumnType("int unsigned");

                    b.HasKey("RegisterId", "CoinId");

                    b.HasIndex("CoinId");

                    b.ToTable("RegisterCoin");
                });

            modelBuilder.Entity("ChangeManager.Domain.Entities.RegisterCoin", b =>
                {
                    b.HasOne("ChangeManager.Domain.Entities.Coin", "Coin")
                        .WithMany("RegisterCoins")
                        .HasForeignKey("CoinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChangeManager.Domain.Entities.Register", "Register")
                        .WithMany("RegisterCoins")
                        .HasForeignKey("RegisterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
