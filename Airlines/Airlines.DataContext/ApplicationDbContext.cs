using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Airlines.BaseModels;
using Airlines.Models;
using Airlines.DataContext.Contracts;
using Microsoft.EntityFrameworkCore;
using Airlines.Seed;

namespace DataContext
{
    public class ApplicationDbContext : DbContext, IUnitOfWork //Dependanct injection (learn this)
                                                               //Open Close method (learn this)
    {
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Flight> Fligts { get; set; }
        public DbSet<FlightStatus> FlightStatuses { get; set; }
        public DbSet<FlightStatusChange> FlightStatusChanges { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-TTNBSCK;Database=Airlines;Trusted_Connection=True;" +
                "TrustServerCertificate=true;");
        } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Payroll>().HasOne<Ticket>().WithOne(x => x.Payroll).OnDelete(DeleteBehavior.Cascade);
           // DataSeed.ExampleSeed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries<IBaseModels>()
                .Where(x => x.Entity is IBaseModels).ToList(); // not done yet

            foreach (var entry in entries)
            {
                IBaseModels model = (IBaseModels)entry.Entity;
                if (entry.State == EntityState.Added)
                {
                    model.CreatedAt = DateTimeOffset.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    model.UpdatedAt = DateTimeOffset.Now;
                }
                else if (entry.State == EntityState.Deleted)
                {
                    model.DeletedAt = DateTimeOffset.Now;
                    entry.State = EntityState.Modified;
                }
            }
            return base.SaveChanges();
        }

    }
}
