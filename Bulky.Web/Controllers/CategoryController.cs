using Bulky.Web.Data;
using Bulky.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bulky.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Category> categories = _dbContext.Categories.ToList();

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
