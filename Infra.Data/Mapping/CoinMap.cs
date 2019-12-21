using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChangeManager.Infra.Data.Mapping
{
    internal class CoinMap : IEntityTypeConfiguration<Coin>
    {
        public void Configure(EntityTypeBuilder<Coin> builder)
        {
            builder.ToTable("coin");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Value)
                .IsRequired()
                .HasColumnName("value");

            builder.HasMany(c => c.RegisterCoins)
                .WithOne(rc => rc.Coin)
                .HasForeignKey(rc => rc.CoinId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
            
            builder.HasAlternateKey(c => c.Value).HasName("coin_value_key");

            builder.HasData(new List<Coin>()
            {
                new Coin(){Id=1,Value = 1},//um centavo
                new Coin(){Id=2,Value = 5},//5 centavo
                new Coin(){Id=3,Value = 10},//10 centavo
                new Coin(){Id=4,Value = 25},//25 centavo
                new Coin(){Id=5,Value = 50},//50 centavo
                new Coin(){Id=6,Value = 100},//1 real
                new Coin(){Id=7,Value = 200},//2 real
                new Coin(){Id=8,Value = 500},//5 real
                new Coin(){Id=9,Value = 1000},//10 real
                new Coin(){Id=10,Value = 2000},//20 real
                new Coin(){Id=11,Value = 5000},//50 real
                new Coin(){Id=12,Value = 10000},//100 real
            });
        }
    }
}
