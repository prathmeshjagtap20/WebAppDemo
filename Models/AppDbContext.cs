using System;

using Microsoft.EntityFrameworkCore;

namespace WebAPI_Demo1.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        public DbSet<Student> students { get; set; }

    }
}