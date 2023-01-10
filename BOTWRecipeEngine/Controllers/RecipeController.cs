using BOTWRecipeEngine.Data;
using BOTWRecipeEngine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace BOTWRecipeEngine.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeContext _context;

        public RecipeController(RecipeContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public IActionResult GetRecipe(int id)
        {
            return View();
        }
    }
}
