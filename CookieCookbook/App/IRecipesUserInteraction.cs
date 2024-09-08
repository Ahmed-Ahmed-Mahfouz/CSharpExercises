using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookbook.App;

internal interface IRecipesUserInteraction
{
    public void ShowMessage(string message);

    public void Exit();
    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}
