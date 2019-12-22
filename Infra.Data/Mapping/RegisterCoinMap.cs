using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChangeManager.Infra.Data.Mapping
{
    internal class RegisterCoinMap: IEntityTypeConfiguration<RegisterCoin>
    {
        public void Configure(EntityTypeBuilder<RegisterCoin> builder)
        {
            builder.ToTable("register_coin");

            builder.HasKey(rc => new {rc.RegisterId, rc.CoinId});

            builder.Property(c => c.Quantity)
                .IsRequired()
                .HasColumnName("quantity");

            builder.HasData(new List<RegisterCoin>()
            {
                new RegisterCoin(){CoinId = 1, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 2, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 3, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 4, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 5, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 6, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 7, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 8, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 9, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 10, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 11, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 12, RegisterId = 1, Quantity = 0},
                new RegisterCoin(){CoinId = 1, RegisterId = 2, Quantity = 0},
                new RegisterCoin(){CoinId = 2, RegisterId = 2, Quantity = 0},
                new RegisterCoin(){CoinId = 3, RegisterId = 2, Quantity = 0},
                new RegisterCoin(){CoinId = 4, RegisterId = 2, Quantity = 0},
                new RegisterCoin(){CoinId = 5, RegisterId = 2, Quantity = 0},
                new RegisterCoin(){CoinId = 6, RegisterId = 2, Quantity = 0},
                new RegisterCoin(){CoinId = 7, RegisterId = 2, Quantity = 0},
                new RegisterCoin(){CoinId = 8, RegisterId = 2, Quantity = 0},
                new RegisterCoin(){CoinId = 9, RegisterId = 2, Quantity = 0},
                new RegisterCoin(){CoinId = 10, RegisterId = 2, Quantity = 0},
                new RegisterCoin(){CoinId = 11, RegisterId = 2, Quantity = 0},
                new RegisterCoin(){CoinId = 12, RegisterId = 2, Quantity = 0},
            });
        }
    }
}
