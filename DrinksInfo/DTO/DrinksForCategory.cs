using System.Text.Json.Serialization;

namespace DrinksInfo;

public class DrinksForCategory
{
    [JsonPropertyName("drinks")]
    public List<Drink>? Drinks {get; set;}
}