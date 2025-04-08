using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Cars.Models;
using DataContext.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.SqlServer.Design;

namespace DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; } 
        public DbSet<Engine> Engines { get; set; } 
        public DbSet<Fuel> Fuels { get; set; } 
        public DbSet<Model> Models { get; set; } 
        public DbSet<ModelEngine> ModelEngines { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-TTNBSCK;Database=Cars;Trusted_Connection=True;" +
                "TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model>().HasMany(e => e.Engines)
            .WithMany(f => f.Models).UsingEntity<ModelEngine>();

            DataSeed.ExampleSeed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

    }
}
