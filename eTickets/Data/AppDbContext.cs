﻿using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data

{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
    }
}
