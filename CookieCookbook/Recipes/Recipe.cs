using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

internal class Recipe
{
    public IEnumerable<Ingredient> _ingredients { get; }

    public Recipe(IEnumerable<Ingredient> Ingredients)
    {
        _ingredients = Ingredients;
    }

    public override string ToString()
    {
        var steps = _ingredients.Select(ingredient => $"{ingredient.Name}. {ingredient.PreparationInstructions}")
                                .ToList();
        return string.Join(Environment.NewLine, steps);
    }

}
