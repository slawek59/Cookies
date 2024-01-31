using CookiesRecipeApp.Recipes.Ingredients;

namespace CookiesRecipeApp.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get; }

        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
    }
}
