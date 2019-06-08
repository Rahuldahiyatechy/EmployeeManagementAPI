using Microsoft.EntityFrameworkCore;
using Entities;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<Role> Role{ get; set; }
        public DbSet<TimeTracker> TimeTracker { get; set; }

    }
}


