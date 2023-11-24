using DrinkInfo;
using DrinksInfo;

public class CategoryMenu : MenuFundamental
{
    public CategoryMenu()
    {
        DrinkCategoriesGetter = new();
    }

    public int CategoryMenuDisplay()
    {
        bool validCategorySelection = false;
        while (!validCategorySelection)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Drinks Menu!");
            Console.WriteLine("You may type '-1' to exit the program");
            DisplayCategoryTableNow();
            string response = GetUserResponse("Select a corresponding Id equal to the category of drinks you wish to view");
            int categoryCount = DrinkCategoriesGetter!.DrinkCategoriesContainer!.Categories!.Count();
            int parsedResponse = Int32.Parse(response);

            if (parsedResponse > 0 && parsedResponse <= categoryCount)
            {
                return parsedResponse;
            }
            if (parsedResponse == -1)
            {
                break;
            }
            this.InvalidInput("That id is not on the list, please try again!");
        }

        return -1;
    }    

    private void DisplayCategoryTableNow()
    {
        DrinkCategories drinkCategories = DrinkCategoriesGetter.GetCatagories();

        Tables.DisplayCategoriesTable(drinkCategories);
        // Console.WriteLine(Uri.EscapeDataString("Other / Unknown"));
    }

    private CategoryRetriever DrinkCategoriesGetter {get; init;}
}