using bookStoreTurkcell.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Data
{
    public class bookStoreTurkcellDbContext : DbContext
    {
        public bookStoreTurkcellDbContext(DbContextOptions<bookStoreTurkcellDbContext> options):base(options)
        {
                
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Genre> Genres{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasOne(b => b.Author)
                                       .WithMany(a => a.Books)
                                       .HasForeignKey(b => b.AuthorID);


            modelBuilder.Entity<Book>().HasOne(b => b.Publisher)
                                       .WithMany(p => p.Books)
                                       .HasForeignKey(f => f.PublisherID);

            modelBuilder.Entity<Book>().HasOne(b => b.Genre)
                                       .WithMany(g => g.Books)
                                       .HasForeignKey(k => k.GenreID);

            modelBuilder.Entity<User>().HasOne(r => r.UserRole)
                                       .WithMany(u => u.Users)
                                       .HasForeignKey(k => k.UserRoleID);

            base.OnModelCreating(modelBuilder);
        }




    }
}
