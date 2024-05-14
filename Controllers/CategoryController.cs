using Chapterverse.DAL;
using Chapterverse.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chapterverse.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ChapterVerseDbContext _chapterVerseDbContext;

        public CategoryController(ChapterVerseDbContext chapterVerseDbContext)
        {            
            _chapterVerseDbContext = chapterVerseDbContext;
        }
        public IActionResult Index()
        {
            List<Category> categObj = _chapterVerseDbContext.Categories.ToList();
            return View(categObj);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
