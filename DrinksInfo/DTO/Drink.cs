using System.Text.Json.Serialization;

namespace DrinksInfo;

public class Drink
{
    [JsonPropertyName("strDrink")]
    public string? DrinkName {get; set;} 
    [JsonPropertyName("strDrinThumb")]
    public string? DrinkImage {get; set;}
    [JsonPropertyName("idDrink")]
    public string? DrinkId {get; set;}
}