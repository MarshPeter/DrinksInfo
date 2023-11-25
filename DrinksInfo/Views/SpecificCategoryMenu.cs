using System.Xml.Serialization;
using DrinkInfo;

namespace DrinksInfo;

public class SpecificCategoryMenu : MenuFundamental
{
    public SpecificCategoryMenu(CategoryRetriever retriever)
    {
        CategoryRetriever = retriever;
    }
    public int GetCategoryInfo(int categoryChoice)
    {
        if (CategoryRetriever.DrinkCategoriesContainer.Categories == null)
        {
            this.IrresolvableError("Could not find the Categories save, exiting the program");
        }
        List<DrinkCategory> categories = CategoryRetriever.DrinkCategoriesContainer.Categories!; 

        string chosenCategory = categories[categoryChoice].CategoryName!;

        string apiEnding = "c=" + Uri.EscapeDataString(chosenCategory);

        while (true)
        {
            DisplayTables(apiEnding);
            Console.WriteLine($"Here are the drinks for the category: {chosenCategory}");
            string response = this.GetUserResponse("Enter an id corresponding to the drink you wish to view");
            
            int parsedResponse = Int32.Parse(response);

            if (parsedResponse < 1 && parsedResponse > categories.Count + 1)
            {
                this.InvalidInput("That is not a valid input, it needs to be an id in the list");
                continue;
            }
            return parsedResponse - 1;
        }
    }

    public void DisplayTables(string apiEnding)
    {
        DrinksForCategory drinks = CategoryRetriever.GetSpecificCategory(apiEnding);

        Tables.DisplayDrinksForCategory(drinks);
    }

    private CategoryRetriever CategoryRetriever {get; init;}
}