using CNC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CNC.Data
{
    public class CNCContext : DbContext
    {
        #region Entities

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Episode> Episodes { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Lyric> Lyrics { get; set; } 

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Music> Music { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Season> Seasons { get; set; }

        public DbSet<Serie> Series { get; set; }

        #endregion

        public CNCContext(DbContextOptions<CNCContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("cnc");

            #region Disabling on delete actions

            modelBuilder.Entity<Episode>()
                .HasOne(e => e.Serie)
                .WithMany(s => s.Episodes)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Serie>()
                .HasMany(s => s.Episodes)
                .WithOne(e => e.Serie)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}