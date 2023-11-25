
using System.Threading.Channels;
using DrinkInfo;

namespace DrinksInfo;

public class MenuController
{
    public MenuController()
    {
        CategoryRetriever retriever = new();
        SelectCategoryMenu = new CategoryMenu(retriever);
        SelectDrinkMenu = new SpecificCategoryMenu(retriever);
    }

    public void OpperateProgram()
    {
        int selection = SelectCategoryMenu.CategoryMenuDisplay();
        int chosenDrinkIndex = SelectDrinkMenu.GetCategoryInfo(selection);
        Console.WriteLine($"Chosen index was: {chosenDrinkIndex}");
    }
    private CategoryMenu SelectCategoryMenu {get; set;}
    private SpecificCategoryMenu SelectDrinkMenu {get; set;}
}