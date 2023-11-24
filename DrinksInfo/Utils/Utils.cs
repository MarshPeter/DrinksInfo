using System.Net.Http.Headers;

namespace DrinksInfo;
public class Utils
{
    public static string GetCategoryJson(string uri)
    {
        using HttpClient client = new();

        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        try
        { 
            var response = client.GetAsync(uri).Result;

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return json;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        } 
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            Environment.Exit(1);
        }

        return "";
    }
}