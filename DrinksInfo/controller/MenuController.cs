
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
        SelectDrinkMenu.GetCategoryInfo(selection);
    }


    private CategoryMenu SelectCategoryMenu {get; set;}
    private SpecificCategoryMenu SelectDrinkMenu {get; set;}
}