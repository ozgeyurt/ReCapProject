using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class DailyCarRentalContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=DailyCarRantal;Integrated Security=True");
        }
        public DbSet <Car> Cars { get; set; }
        public DbSet <Brand> Brands { get; set; }
        public DbSet <Color> Colors { get; set; }
    }
}
