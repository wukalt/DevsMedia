using Delt.Models;
using Microsoft.EntityFrameworkCore;

namespace Delt.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Seminar> Seminars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher() { Id = 1, Bio = "not to as", Experience = 7, Name = "ali", Family = ",p", ProfileImage = "null for bnow" }
                );

            modelBuilder.Entity<Seminar>().HasData(
                new Seminar() { Id = 1, Title = "this is title", CoverImage = "null for now", Level = Models.Enums.SeminarLevel.Starter, ShortDescription = "dksjjdksjdkjskjdksjdksjdkjskdkjsd", TeacherId = 1 }
                );
        }
    }
}
