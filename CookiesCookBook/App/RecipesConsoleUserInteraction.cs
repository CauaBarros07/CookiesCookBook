
using CookiesCookBook.Recipes;

namespace CookiesCookBook.App;

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    private readonly IIngredientsRegister _ingredientsRegister;

    public RecipesConsoleUserInteraction(
        IIngredientsRegister ingredientsRegister)
    {
        _ingredientsRegister = ingredientsRegister;
    }
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are:" + Environment.NewLine);

            var counter = 1;
            foreach (var recipe in allRecipes)
            {
                Console.WriteLine($"*****{counter}******");
                Console.WriteLine(recipe);
                Console.WriteLine();
                ++counter;
            }
        }
    }

    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! " +
            "Avaible ingredients are:");

        foreach (var ingredient in _ingredientsRegister.All)
        {
            Console.WriteLine(ingredient);

        }
    }

    public IEnumerable<Ingredient> ReadIngredientsFromUser()
    {
        bool shallStop = false;
        var igredients = new List<Ingredient>();

        while (!shallStop)
        {
            Console.WriteLine("Add an igredient by its ID, " +
                "or type anything else if finished.");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int id))
            {
                var selectedIgredient = _ingredientsRegister.GetById(id);
                if (selectedIgredient is not null)
                {
                    igredients.Add(selectedIgredient);
                }
            }
            else
            {
                shallStop = true;
            }

        }
        return igredients;
    }
}
