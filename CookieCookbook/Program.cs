using CookieCookbook.App;
using CookieCookbook.DataAccess;
using CookieCookbook.FileAccess;
using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook;

internal class Program
{
    static void Main(string[] args)
    {
        const FileFormat Format = FileFormat.Json;

        IStringsRepository stringsRepository = Format == FileFormat.Json ?
            new StringsJsonRepository(): 
            new StringsTextualRepository();

        const string FileName = "recipes";

        var fileMetadata = new FileMetadata(FileName, Format);

        var ingredientsRegister = new IngredientsRegister();

        var stringsTextualRepository = new StringsTextualRepository();

        var recipesRepository = new RecipesRepository(stringsRepository, ingredientsRegister);

        var recipesConsoleUserInteraction = new RecipesConsoleUserInteraction(ingredientsRegister);

        var cookiesRecipesApp = new CookiesRecipesApp(recipesRepository,recipesConsoleUserInteraction);

        cookiesRecipesApp.Run(fileMetadata.ToPath());

    }
}
