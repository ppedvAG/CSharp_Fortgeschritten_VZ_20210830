using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheDataLayer.Context
{
    public partial class GeoDBContext : DbContext
    {
        public GeoDBContext()
        {
        }

        public GeoDBContext(DbContextOptions<GeoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Continent> Continent { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryLanguage> CountryLanguage { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<StateLanguage> StateLanguage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=GeoDB;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Country");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_State");
            });

            modelBuilder.Entity<Continent>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.HasOne(d => d.Continent)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.ContinentId)
                    .HasConstraintName("FK_Country_Continent");
            });

            modelBuilder.Entity<CountryLanguage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryLanguage)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CountryLanguage_Country");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.CountryLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_CountryLanguage_Language");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Language1)
                    .HasColumnName("Language")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Flag).IsRequired();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_State_Country");
            });

            modelBuilder.Entity<StateLanguage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateLanguage)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_StateLanguage_Country");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.StateLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_StateLanguage_Language");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.StateLanguage)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_StateLanguage_State");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
