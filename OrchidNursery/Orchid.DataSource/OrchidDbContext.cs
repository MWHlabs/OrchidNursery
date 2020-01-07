using Microsoft.EntityFrameworkCore;
using Orchid.DataSource.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orchid.DataSource
{
    public class OrchidDbContext : DbContext
    {
        //public OrchidDbContext(DbContextOptions<OrchidDbContext> options) : base(options)
        //{
        //    Database.Migrate();
        //}

        public DbSet<Orchids> Orchids { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string SqlConnectionString = "Server=DESKTOP-Q4TN76O\\CHEFASQL;Database=OrchidDatabase;Trusted_Connection=true;";

            builder.UseSqlServer(SqlConnectionString);

            base.OnConfiguring(builder);
        }
    }
}
