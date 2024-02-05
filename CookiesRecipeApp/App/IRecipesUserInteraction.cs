using CookiesRecipeApp.Recipes;
using CookiesRecipeApp.Recipes.Ingredients;

namespace CookiesRecipeApp.App;

public interface IRecipesUserInteraction
{
	void ShowMessage(string message);
	void Exit();
	void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
	void PromptToCreateRecipe();
	IEnumerable<Ingredient> ReadIngredientsFromUser();
}
