using Chapterverse.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapterverse.DAL
{
    public class ChapterVerseDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; } 
        public ChapterVerseDbContext(DbContextOptions<ChapterVerseDbContext> options):base(options) { 
        
        }

    }
}
