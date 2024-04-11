using System;
using System.Collections.Generic;

namespace RecipeApp
{
    class Recipe
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }

        public Recipe(List<Ingredient> ingredients, List<string> steps)
        {
            Ingredients = ingredients;
            Steps = steps;
        }

        public void Rescale(int option)
        {
            double scale;
            switch (option)
            {
                case 1:
                    scale = 0.5;
                    break;
                case 2:
                    scale = 1.0;
                    break;
                case 3:
                    scale = 2.0;
                    break;
                case 4:
                    scale = 3.0;
                    break;
                default:
                    Console.WriteLine("Invalid rescale option.");
                    return;
            }

            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.Quantity *= scale;
            }
        }

        public void ResetQuantity()
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.Quantity = 1.0;
            }
        }

        public override string ToString()
        {
            string recipe = "Ingredients:\n";
            foreach (Ingredient ingredient in Ingredients)
            {
                recipe += $"{ingredient}\n";
            }

            recipe += "\nSteps:\n";
            for (int i = 0; i < Steps.Count; i++)
            {
                recipe += $"{i + 1}. {Steps[i]}\n";
            }

            return recipe;
        }
    }
}