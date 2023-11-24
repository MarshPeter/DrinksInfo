namespace DrinkInfo;
using System.Configuration;
using System.Text.Json;
using DrinksInfo;

public class CategoryRetriever
{
    public CategoryRetriever()
    {
        DrinkCategories DrinkCategoriesContainer = new();
        DrinksForCategory DrinksForLastCategory = new();
        try
        {
            CategoryGetUri = ConfigurationManager.AppSettings.Get("CategoryChoicesUri")!;
            BaseCategoryUri = ConfigurationManager.AppSettings.Get("BaseApiUri")!;
        }
        catch (Exception e)
        {
            Console.WriteLine("There was an error getting the app settings");
            Console.WriteLine("ERROR: " + e);
            Environment.Exit(1);
        }
    }

    public DrinkCategories GetCatagories()
    {
        string json = Utils.GetCategoryJson(CategoryGetUri);
        if (json == "")
        {
            EmptyJsonResult("There was an error with retrieving JSON for the list of categories");
        }
        DrinkCategoriesContainer = JsonSerializer.Deserialize<DrinkCategories>(json)!;

        return DrinkCategoriesContainer;       
    }

    public DrinksForCategory GetSpecificCategory(String category)
    {
        string json = Utils.GetCategoryJson(CategoryGetUri);
        if (json == "")
        {
            EmptyJsonResult($"There was an error with retrieving JSON for the category '{category}'");
        }

        DrinksForLastCategory = JsonSerializer.Deserialize<DrinksForCategory>(json)!;
        return DrinksForLastCategory;
    }


    private void EmptyJsonResult(string message)
    {
        Console.WriteLine(message);
        Environment.Exit(1);
    }

    private string CategoryGetUri {get; init;}
    private string BaseCategoryUri {get; init;}
    public DrinkCategories DrinkCategoriesContainer {get; set;}
    public DrinksForCategory DrinksForLastCategory {get; set;}
}