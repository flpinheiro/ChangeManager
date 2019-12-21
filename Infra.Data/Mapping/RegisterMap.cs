using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChangeManager.Infra.Data.Mapping
{
    internal class RegisterMap: IEntityTypeConfiguration<Register>
    {
        public void Configure(EntityTypeBuilder<Register> builder)
        {
            builder.ToTable("register");

            builder.Property(r => r.Name)
                .IsRequired()
                .HasColumnName("name");

            builder.HasMany(r => r.RegisterCoins)
                .WithOne(rc => rc.Register)
                .HasForeignKey(rc => rc.RegisterId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
        }
    }
}
