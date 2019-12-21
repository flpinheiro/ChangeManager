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

            builder.Property(c => c.Quantity)
                .IsRequired()
                .HasColumnName("quantity");

            builder.HasMany(c => c.RegisterCoins)
                .WithOne(rc => rc.Coin)
                .HasForeignKey(rc => rc.CoinId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
        }
    }
}
