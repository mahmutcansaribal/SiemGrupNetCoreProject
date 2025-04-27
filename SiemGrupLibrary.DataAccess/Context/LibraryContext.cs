using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiemGrupLibrary.Entities.Entities;

namespace SiemGrupLibrary.DataAccess.Context
{
    public class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=mahmutcan\\SQLEXPRESS;initial catalog=SiemGrupLibraryManagement;integrated security=true");
        }

        public DbSet<Author> Authors { get; set; } 
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>()
                .HasMany(a=> a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b=>b.AuthorID)
                .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
        }
    }
}
