using System.Xml.Serialization;
using DrinkInfo;

namespace DrinksInfo;

public class SpecificCategoryMenu : MenuFundamental
{
    public SpecificCategoryMenu(CategoryRetriever retriever)
    {
        CategoryRetriever = retriever;
    }
    public void GetCategoryInfo(int categoryChoice)
    {
        if (CategoryRetriever.DrinkCategoriesContainer.Categories == null)
        {
            this.IrresolvableError("Could not find the Categories save, exiting the program");
        }
        List<DrinkCategory> categories = CategoryRetriever.DrinkCategoriesContainer.Categories!; 

        string chosenCategory = categories[categoryChoice].CategoryName!;

        string apiEnding = "c=" + Uri.EscapeDataString(chosenCategory);

        DrinksForCategory drinks = CategoryRetriever.GetSpecificCategory(apiEnding);

        foreach (Drink categoryDrink in drinks.Drinks!)
        {
            Console.WriteLine(categoryDrink.DrinkName);
        }
    }

    private CategoryRetriever CategoryRetriever {get; init;}
}