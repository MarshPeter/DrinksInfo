using ConsoleTableExt;

namespace DrinksInfo;

public class Tables
{
    public static void DisplayCategoriesTable(DrinkCategories drinkCategories)
    {
        List<List<object>> tableData = new();
        int count = 1;

        foreach (DrinkCategory category in drinkCategories.Categories!)
        {
            tableData.Add(new List<object>{count++, category.CategoryName!}); 
        }

        ConsoleTableBuilder.From(tableData).ExportAndWriteLine();
    }
}