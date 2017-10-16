using WebAPI.Abstraction;
using WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Context
{
    public class EFContext : DbContext, IEFDbContext
    {
        public EFContext(DbContextOptions<EFContext> options) 
            : base(options)
        {

        }

        public DbSet<HeartRate> HeartRate { get; set; }
        public DbSet<Accelero> Accelero { get; set; }

        public void SaveDbChanges()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeartRate>().ToTable("HeartRate");
            modelBuilder.Entity<Accelero>().ToTable("Accelero");
        }
    }
}
