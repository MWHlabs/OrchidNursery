using Microsoft.EntityFrameworkCore;
using OrchidModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrchidModel
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<OrchidNew> OrchidNews { get; set; }
        public object OrchidNew { get;  set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string SqlConnectionString = "Server=DESKTOP-Q4TN76O\\CHEFASQL;Database=OrchidDatabase;Trusted_Connection=true;";

            builder.UseSqlServer(SqlConnectionString);

            base.OnConfiguring(builder);
        }
    }
}
