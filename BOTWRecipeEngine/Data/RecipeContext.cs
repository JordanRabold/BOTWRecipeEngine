using Microsoft.EntityFrameworkCore;
using BOTWRecipeEngine.Models;

namespace BOTWRecipeEngine.Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {

        }
        public DbSet<Botw_Recipes> Recipes { get; set; }
    }
}
