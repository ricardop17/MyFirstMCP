using System.ComponentModel;
using System.Text.Json;
using ModelContextProtocol.Server;

namespace MyFirstMCP;

[McpServerToolType]
public static class JokeTools
{
    [McpServerTool, Description("Get an awesome and lovely joke.")]
    public static async Task<string> GetLovelyJoke(JokeService service)
    {
        var joke = await service.GetJoke();
        return JsonSerializer.Serialize(joke);
    }
}
