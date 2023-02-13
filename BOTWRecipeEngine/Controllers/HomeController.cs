using Azure;
using BOTWRecipeEngine.Data;
using BOTWRecipeEngine.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BOTWRecipeEngine.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RecipeContext _context;

        public HomeController(ILogger<HomeController> logger, RecipeContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult SearchRecipes(){
            //List<Botw_Recipes> recipeList = new List<Botw_Recipes>();
            /*String apiURL = "https://localhost:7075/api/GetRecipe/1";
            HttpClient client = new HttpClient();
            HttpResponseMessage message = client.GetAsync(apiURL).Result;
            if (message.IsSuccessStatusCode)
            {
                recipeList = JsonConvert.DeserializeObject<System.Data.DataTable>(message);
            }*/

            var recipeList = new RecipeController(_context).GetRecipe(1);


            return View(recipeList);
        }

        public IActionResult Index()
        {
            var recipeList = new RecipeController(_context).GetRecipe(1);


            return(recipeList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}