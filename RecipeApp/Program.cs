using System;
using System.Collections.Generic;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Recipe App!");

            while (true)
            {
                Console.WriteLine("\nPlease enter recipe details:");

                Console.Write("Number of ingredients: ");
                int ingredientCount = int.Parse(Console.ReadLine());

                List<Ingredient> ingredients = new List<Ingredient>();
                for (int i = 0; i < ingredientCount; i++)
                {
                    Console.WriteLine($"\nIngredient {i + 1}:");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Quantity: ");
                    double quantity = double.Parse(Console.ReadLine());
                    Console.Write("Unit of measurement: ");
                    string unit = Console.ReadLine();

                    ingredients.Add(new Ingredient(name, quantity, unit));
                }

                Console.Write("\nNumber of steps: ");
                int stepCount = int.Parse(Console.ReadLine());

                List<string> steps = new List<string>();
                for (int i = 0; i < stepCount; i++)
                {
                    Console.WriteLine($"\nStep {i + 1}:");
                    Console.Write("What to do: ");
                    steps.Add(Console.ReadLine());
                }

                Recipe recipe = new Recipe(ingredients, steps);

                Console.WriteLine("\nRecipe details:");
                Console.WriteLine(recipe);

                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Rescale recipe");
                Console.WriteLine("2. Reset quantity");
                Console.WriteLine("3. Clear recipe");
                Console.WriteLine("4. Exit");

                Console.Write("Enter option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nRescale recipe:");
                        Console.WriteLine("1. Half");
                        Console.WriteLine("2. 1 person");
                        Console.WriteLine("3. 2 people");
                        Console.WriteLine("4. 3 people");
                        Console.Write("Enter option: ");
                        int rescaleOption = int.Parse(Console.ReadLine());
                        recipe.Rescale(rescaleOption);
                        Console.WriteLine("\nRescaled recipe details:");
                        Console.WriteLine(recipe);
                        break;
                    case 2:
                        recipe.ResetQuantity();
                        Console.WriteLine("\nQuantity reset to 1.");
                        Console.WriteLine("\nRecipe details:");
                        Console.WriteLine(recipe);
                        break;
                    case 3:
                        Console.WriteLine("\nRecipe cleared.");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}