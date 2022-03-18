
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(user => user.Role).HasDefaultValue("Applicant");
        }
    }
}
