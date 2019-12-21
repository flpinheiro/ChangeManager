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
            builder.HasIndex(rc => new {rc.RegisterId, rc.CoinId});
        }
    }
}
