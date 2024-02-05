namespace CookiesRecipeApp.Recipes.Ingredients;

    public abstract class Spice : Ingredient
    {
        public override string PreparationInstructions => $"Take half of a teaspoon. {base.PreparationInstructions}";
    }
