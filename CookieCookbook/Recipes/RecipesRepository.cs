using CookieCookbook.DataAccess;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

internal class RecipesRepository : IRecipesRepository
{
    private readonly IStringsRepository _stringsRepository;
    private readonly IIngredientsRegister _ingredientRegister;
    private const string Separator = ",";

    public RecipesRepository(
        IStringsRepository stringsRepository,
        IIngredientsRegister ingredientRegister)
    {
        _stringsRepository = stringsRepository;
        _ingredientRegister = ingredientRegister;
    }

    public List<Recipe> Read(string filePath)
    {
        return _stringsRepository.Read(filePath)
                                 .Select(RecipeFromString)
                                 .ToList();
    }

    private Recipe RecipeFromString(string recipeFromFile)
    {
        var ingredients = recipeFromFile.Split(Separator)
                                        .Select(int.Parse)
                                        .Select(_ingredientRegister.GetById);

        return new Recipe(ingredients);
    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        var recipesAsStrings = allRecipes.Select(recipe =>
        {
            var allIds = recipe._ingredients.Select(ingredient => ingredient.Id);
            return string.Join(Separator, allIds);
        });

        _stringsRepository.Write(filePath, recipesAsStrings.ToList());
    }
}