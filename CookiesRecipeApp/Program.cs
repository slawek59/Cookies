

var cookiesRecipeBook = new CookiesRecipesApp();
cookiesRecipeBook.Run();

public class CookiesRecipesApp
{
	private readonly RecipesRepository _recipesRepository;
	private readonly IRecipesUserInteraction _recipesUserInteraction;

	//target-typed new expression = new ();

    public CookiesRecipesApp(RecipesRepository recipesRepository, RecipesConsoleUserInteraction recipesUserInteraction)
    {
		_recipesRepository = recipesRepository;
		_recipesUserInteraction = recipesUserInteraction;
	}
    public void Run()
	{
		var allRecipes = _recipesRepository.ReadAll(filePath);
		_recipesUserInteraction.PrintExistingRecipes(allRecipes);

		_recipesUserInteraction.PromptToCreateRecipe();

		var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

		if (ingredients.Count > 0)
		{
			var recipes = new Recipe(ingredients);
			allRecipes.Add(recipe);
			_recipesRepository.Write(filePath, allRecipes);

			_recipesUserInteraction.ShowMessage("Recipe added:");
			_recipesUserInteraction.ShowMessage(recipes.ToString());
		}
		else
		{
			_recipesUserInteraction.ShowMessage("No ingredients have been selected. " + "Recipe will not be saved.");
		}

		_recipesUserInteraction.Exit();
	}
}

public interface IRecipesUserInteraction
{
	void ShowMessage(string message);
	void Exit();
}

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
	public void ShowMessage(string message)
	{
        Console.WriteLine(message);
    }

	public void Exit()
	{
        Console.WriteLine("Press any key to exit.");
		Console.ReadKey();
    }
}

public class RecipesRepository
{
}