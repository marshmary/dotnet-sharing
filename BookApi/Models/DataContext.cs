using BookApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Data
{
    class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Book 1", Author = "Author 1", PublishDate = DateTime.Now},
                new Book { Id = 2, Title = "Book 2", Author = "Author 2", PublishDate = DateTime.Now},
                new Book { Id = 3, Title = "Book 3", Author = "Author 3", PublishDate = DateTime.Now}
            );
        }
    }
}