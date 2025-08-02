using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyFirstMCP;

public class JokeService(IHttpClientFactory httpClientFactory)
{
    private readonly HttpClient httpClient = httpClientFactory.CreateClient();

    public async Task<Joke?> GetJoke()
    {
        var response = await httpClient.GetAsync(
            "https://official-joke-api.appspot.com/random_joke"
        );

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Joke>(json);
        }

        return new Joke();
    }
}

public class Joke
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("setup")]
    public string? Setup { get; set; }

    [JsonPropertyName("punchline")]
    public string? Punchline { get; set; }
}
