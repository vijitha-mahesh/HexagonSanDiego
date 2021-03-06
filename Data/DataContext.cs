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
        public DbSet<Location> locations { get; set; }
        public DbSet<FloorPlan> FloorPlans { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<HomePageDataModel> HomePages { get; set; }
        public DbSet<VertualTours> VertualTour { get; set; }    
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<ContactUs> ContactUss { get; set; }
        public DbSet<Accessbility> Accessbilities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(user => user.Role).HasDefaultValue("Admin");
        }
    }
}
