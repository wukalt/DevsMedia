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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book() { Id = 1, Title = "C# 12 and .NET 8 – Modern Cross-Platform Development Fundamentals Eighth Edition", ShortDescription = ".NET8  آخرین نسخه اصلی از فریم ورک دات نت است، که پس از انتشار نسخه‌های قبلی، این وعده را به کاربران خود داده است که مجموعه‌ای از ویژگی‌های جدید، پیشرفت‌ها و قابلیت‌های جدید را برای توانمند‌سازی بیشتر توسعه‌دهندگان و ایجاد توسعه برنامه‌های کاربردی و لذت بخش به ارمغان بیاورد", CoverImage = "https://content.packt.com/_/image/original/B19586/cover_image_large.jpg" },
                new Book() { Id = 2 , Title = "Cyber", ShortDescription = ".NET8  آخرین نسخه اصلی از فریم ورک دات نت است، که پس از انتشار نسخه‌های قبلی، این وعده را به کاربران خود داده است که مجموعه‌ای از ویژگی‌های جدید، پیشرفت‌ها و قابلیت‌های جدید را برای توانمند‌سازی بیشتر توسعه‌دهندگان و ایجاد توسعه برنامه‌های کاربردی و لذت بخش به ارمغان بیاورد", CoverImage = "https://content.packt.com/_/image/original/B02765/cover_image_large.jpg" }
                );

            modelBuilder.Entity<Blog>().HasData(
                new Blog() {Id =1, Title = "چگونه در سی شارپ SOLID را پیاده سازی کنیم", BlogText = "SOLID که متشکل از 5 اصل است در برنامه نویسی  بهتر کمک میکمند", ShortDescription = "SOLID که متشکل از 5 اصل است در برنامه نویسی  بهتر کمک میکمند", CoverImage="null for now" },
                new Blog() {Id =2, Title = "Asyncronous را پیاده سازی کنیم", BlogText = "async await که متشک  بهتر کمک میکمند", ShortDescription = "SOLID که متشکل از 5 اصل است در برنامه نویسی  بهتر کمک میکمند", CoverImage="null for now" }
                );
            }
        }
    }
