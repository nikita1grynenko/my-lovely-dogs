using MyLovelyDogs.Application.Contracts;
using MyLovelyDogs.Domain.Models;
using MyLovelyDogs.Infrastructure.ExternalServices;

namespace MyLovelyDogs.Application.Services;

public class DogService : IDogService
{
    private readonly TheDogApiClient _catApiClient;

    public DogService(TheDogApiClient catApiClient)
    {
        _catApiClient = catApiClient;
    }

    public async Task<Image?> GetDogImageByIdAsync(string imageId)
    {
        return await _catApiClient.GetDogImageByIdAsync(imageId);
    }
    
}