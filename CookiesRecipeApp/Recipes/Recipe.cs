using CookiesRecipeApp.Recipes.Ingredients;

namespace CookiesRecipeApp.Recipes;

public partial class Recipe
{
	public IEnumerable<Ingredient> Ingredients { get; }

	public Recipe(IEnumerable<Ingredient> ingredients)
	{
		Ingredients = ingredients;
	}

	public override string ToString()
	{
		var steps = new List<string>();
		foreach (var ingredient in Ingredients)
		{
			steps.Add($"{ingredient.Name}. {ingredient.PreparationInstructions}");
		}

		return string.Join(Environment.NewLine, steps);
	}
}
