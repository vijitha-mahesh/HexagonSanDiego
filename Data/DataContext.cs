﻿
using HexagonSanDiego.Model;
using HexagonSanDiego.Models;
using Microsoft.EntityFrameworkCore;

namespace HexagonSanDiego.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<FloorPlan> FloorPlans { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<HomePage> HomePages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(user => user.Role).HasDefaultValue("Admin");
        }
    }
}
