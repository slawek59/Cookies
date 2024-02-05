namespace CookiesRecipeApp.Recipes;

public partial class Recipe
{
	public interface IRecipesRepository
	{
		List<Recipe> Read(string filePath);
		void Write(string filePath, List<Recipe> allRecipes);
	}
}
