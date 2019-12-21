using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChangeManager.Infra.Data.Mapping
{
    internal class RegisterMap : IEntityTypeConfiguration<Register>
    {
        public void Configure(EntityTypeBuilder<Register> builder)
        {
            builder.ToTable("register");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name)
                .IsRequired()
                .HasColumnName("name");

            builder.HasMany(r => r.RegisterCoins)
                .WithOne(rc => rc.Register)
                .HasForeignKey(rc => rc.RegisterId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder.HasData(new List<Register>()
            {
                new Register(){Id=1, Name = "Box 1"},
                new Register(){Id = 2, Name = "Box 2"}
            });
        }
    }
}
