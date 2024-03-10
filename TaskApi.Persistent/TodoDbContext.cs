using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskApi.Models;

namespace TaskApi.Persistent
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;Database=TodoDb;TrustServerCertificate=True;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author {Id = 1, Name = "Tharindu"},
                new Author {Id = 2, Name = "Pasan"},
                new Author {Id = 3, Name = "Namal"},
                new Author {Id = 4, Name = "Kamal"},
                new Author {Id = 5, Name = "Ruwan"},
            });
            modelBuilder.Entity<Todo>().HasData(new Todo 
            {
                Id = 1,
                Title = "Task 1",
                Description = "This is task from DB",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(1),
                Status = TodoStatus.New,
                AuthorId = 1,

            
            });
        }
    }
}
