using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tombstone.Recipes
{
    public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(321, 1); // Gravestone
			recipe.SetResult(62, 20); // Grass seeds
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(321, 2); // Gravestone
            recipe.SetResult(195, 20); // Jungle Grass seeds
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(321, 5); // Gravestone
            recipe.SetResult(29, 1); // Life Crystal
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(321, 5); // Gravestone
            recipe.SetResult(109, 1); // Mana Crystal
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(321, 10); // Gravestone
            recipe.SetResult(3368, 1); // Arkhalis
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(321, 10); // Gravestone
            recipe.SetResult(2608, 1); // Falcon Blade
            recipe.AddRecipe();
			
			// New Tombstone Section (because I don't know how to use object groups)
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1173, 2); // Gravestone
			recipe.SetResult(62, 20); // Grass seeds
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1173, 2); // Gravestone
            recipe.SetResult(195, 20); // Jungle Grass seeds
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1173, 5); // Gravestone
            recipe.SetResult(29, 1); // Life Crystal
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1173, 5); // Gravestone
            recipe.SetResult(109, 1); // Mana Crystal
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1173, 10); // Gravestone
            recipe.SetResult(3368, 1); // Arkhalis
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1173, 10); // Gravestone
            recipe.SetResult(2608, 1); // Falcon Blade
            recipe.AddRecipe();
		}
}
