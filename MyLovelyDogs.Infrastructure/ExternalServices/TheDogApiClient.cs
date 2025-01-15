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

    public async Task<Image?> GetDogImageByIdAsync(int imageId)
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

    public async Task<List<Breed>?> GetDogInfoByNameAsync(string dogName)
    {
        var response = await _httpClient.GetAsync($"/v1/breeds/search?q={dogName}");
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<Breed>>(content, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        });
    }
}