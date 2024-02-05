using CookiesRecipeApp.App;
using CookiesRecipeApp.DataAccess;
using CookiesRecipeApp.FileAccess;
using CookiesRecipeApp.Recipes;
using CookiesRecipeApp.Recipes.Ingredients;
using static CookiesRecipeApp.Recipes.Recipe;

const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
	new StringsJsonRepository() :
	new StringsTextualRepository();
const string FileName = "recipes";
var fileMetadata = new FileMetadata(FileName, Format);

var ingredientsRegister = new IngredientsRegister();

var cookiesRecipeBook = new CookiesRecipesApp(
	new RecipesRepository(
		stringsRepository,
		ingredientsRegister),
	new RecipesConsoleUserInteraction(
		ingredientsRegister));

cookiesRecipeBook.Run(fileMetadata.ToPath());




