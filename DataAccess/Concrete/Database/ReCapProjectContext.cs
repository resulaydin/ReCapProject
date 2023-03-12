using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Database
{
    public class ReCapProjectContext:DbContext
    {

        public DbSet<Car> Cars { get; set; }   
        public DbSet<Color> Colors { get; set; }   
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarDetailDto> CarDetailDtos { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().Property(p => p.DailyPrice).HasPrecision(10, 2);
            base.OnModelCreating(modelBuilder);
        }
    }
}
