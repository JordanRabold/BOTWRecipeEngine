using System.ComponentModel.DataAnnotations;

namespace BOTWRecipeEngine.Models
{
    public class Recipe
    {
        public int ID { get; set; }

        public string RecipeName { get; set; }

        public string IngredientName { get; set; } // TODO: Determine how to handle multiple ingredients

        public string Hearts { get; set; }

        public string RecipePicture { get; set; }
    }
}
