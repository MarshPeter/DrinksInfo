namespace DrinksInfo;

using System.Text.Json.Serialization;

public class DrinkCategory
{
    [JsonPropertyName("strCategory")]

    public string? CategoryName {get; set;}
}

