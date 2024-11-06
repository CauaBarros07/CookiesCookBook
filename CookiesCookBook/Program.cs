

using CookiesCookBook.App;
using CookiesCookBook.DataAccess;
using CookiesCookBook.FileAccess;
using CookiesCookBook.Recipes;
using Microsoft.VisualBasic;
using System.Text.Json;


const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
    new StringsJsonRepository() :
    new StringsTextualRepository();

const string FileName = "recipes";
 var fileMetadata = new FileMetadata(FileName, Format);


var ingredientsRegister = new IngredientsRegister();

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(
        stringsRepository,
        ingredientsRegister),
    new RecipesConsoleUserInteraction(
        ingredientsRegister));

 cookiesRecipesApp.Run(fileMetadata.ToPath());










