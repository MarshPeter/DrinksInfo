namespace DrinksInfo;

using System.Text.Json.Serialization;
public class DrinkCategories
{
    [JsonPropertyName("drinks")]
    public List<DrinkCategory>? Categories {get; set;}
}