using DrinkInfo;

namespace DrinksInfo;

public class SpecificCategoryMenu
{
    public SpecificCategoryMenu(CategoryRetriever retriever)
    {
        CategoryRetriever = retriever;
    }

    private CategoryRetriever CategoryRetriever {get; init;}
}