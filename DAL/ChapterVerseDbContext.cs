using Chapterverse.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapterverse.DAL
{
    public class ChapterVerseDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; } 
        public ChapterVerseDbContext(DbContextOptions<ChapterVerseDbContext> options):base(options) { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Science Fiction", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Fiction", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Horror", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Fantasy", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Romance", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Thriller", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Mystery", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Adventure Fiction", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Comics", DisplayOrder = 9 }
                );
        }

    }
}
