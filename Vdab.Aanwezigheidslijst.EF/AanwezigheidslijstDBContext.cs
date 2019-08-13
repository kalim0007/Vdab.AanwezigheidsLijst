using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Vdab.Aanwezigheidslijst.EF.Model;

namespace Vdab.Aanwezigheidslijst.EF
{
    public class AanwezigheidslijstDBContext : DbContext
    {
        public DbSet<Docent> Docenten { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = aanwezigheidslijst.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docent>()
                .Property(d => d.Naam).IsRequired();
            modelBuilder.Entity<Docent>()
                .Property(d => d.Bedrijf).IsRequired();
            modelBuilder.Entity<Docent>()
                .ToTable("Docenten")
                .HasKey(d => d.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
