using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;
using ChangeManager.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ChangeManager.Infra.Data.Context
{
    public class ChangeManagerContext: DbContext
    {
        public DbSet<Coin> Coins { get; set; }
        public DbSet<Register> Registers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql(connectionString:"Server=[SERVIDOR];Port=[PORTA];Database=modelo;Uid=[USUARIO];Pwd=[SENHA]");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Register>(new RegisterMap().Configure);
            modelBuilder.Entity<Coin>(new CoinMap().Configure);
            modelBuilder.Entity<RegisterCoin>(new RegisterCoinMap().Configure);
        }
    }
}
