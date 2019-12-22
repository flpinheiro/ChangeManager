﻿// <auto-generated />
using ChangeManager.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChangeManager.Infra.Data.Migrations
{
    [DbContext(typeof(ChangeManagerContext))]
    partial class ChangeManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Value")
                        .HasColumnName("value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasAlternateKey("Value")
                        .HasName("coin_value_key");

                    b.ToTable("coin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Value = 1
                        },
                        new
                        {
                            Id = 2,
                            Value = 5
                        },
                        new
                        {
                            Id = 3,
                            Value = 10
                        },
                        new
                        {
                            Id = 4,
                            Value = 25
                        },
                        new
                        {
                            Id = 5,
                            Value = 50
                        },
                        new
                        {
                            Id = 6,
                            Value = 100
                        },
                        new
                        {
                            Id = 7,
                            Value = 200
                        },
                        new
                        {
                            Id = 8,
                            Value = 500
                        },
                        new
                        {
                            Id = 9,
                            Value = 1000
                        },
                        new
                        {
                            Id = 10,
                            Value = 2000
                        },
                        new
                        {
                            Id = 11,
                            Value = 5000
                        },
                        new
                        {
                            Id = 12,
                            Value = 10000
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

                    b.Property<int>("Quantity")
                        .HasColumnName("quantity")
                        .HasColumnType("int");

                    b.HasKey("RegisterId", "CoinId");

                    b.HasIndex("CoinId");

                    b.ToTable("register_coin");

                    b.HasData(
                        new
                        {
                            RegisterId = 1,
                            CoinId = 1,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 1,
                            CoinId = 2,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 1,
                            CoinId = 3,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 1,
                            CoinId = 4,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 1,
                            CoinId = 5,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 1,
                            CoinId = 6,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 1,
                            CoinId = 7,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 1,
                            CoinId = 8,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 1,
                            CoinId = 9,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 1,
                            CoinId = 10,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 1,
                            CoinId = 11,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 1,
                            CoinId = 12,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 1,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 2,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 3,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 4,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 5,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 6,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 7,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 8,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 9,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 10,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 11,
                            Quantity = 0
                        },
                        new
                        {
                            RegisterId = 2,
                            CoinId = 12,
                            Quantity = 0
                        });
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
