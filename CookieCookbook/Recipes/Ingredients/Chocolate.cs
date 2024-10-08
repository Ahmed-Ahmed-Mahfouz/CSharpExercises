﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookbook.Recipes.Ingredients;

internal class Chocolate : Ingredient
{
    public override int Id => 4;
    public override string Name => "Chocolate";
    public override string PreparationInstructions => $"Melt in a water bath. {base.PreparationInstructions}";
}
