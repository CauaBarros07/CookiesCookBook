using static CookiesCookBook.Recipes.RecipesRepository;

namespace CookiesCookBook.Recipes;

public interface IRecipesRepository
{
    List<Recipe> Read(string filePath);
    void Write(string filePath, List<Recipe> allRecipes);
}

