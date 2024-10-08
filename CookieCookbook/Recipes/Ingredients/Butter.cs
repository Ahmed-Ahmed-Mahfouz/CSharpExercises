﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookbook.Recipes.Ingredients;

internal class Butter : Ingredient
{
    public override int Id => 3;

    public override string Name => "Butter";

    public override string PreparationInstructions => $"Melt on low heat. {base.PreparationInstructions}";
}
