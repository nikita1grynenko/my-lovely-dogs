using System.Text.Json;
using MyLovelyDogs.Domain.Models;
using MyLovelyDogs.Infrastructure.Contracts;

namespace MyLovelyDogs.Infrastructure.ExternalServices;

public class TheDogApiClient : ITheDogApiClient
{
    private readonly HttpClient _httpClient;

    public TheDogApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Image?> GetDogImageByIdAsync(string imageId)
    {
        var response = await _httpClient.GetAsync($"/v1/images/{imageId}");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<Image>(content, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        });
    }
}