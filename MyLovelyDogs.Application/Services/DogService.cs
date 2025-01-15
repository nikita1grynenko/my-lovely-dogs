using MyLovelyDogs.Application.Contracts;
using MyLovelyDogs.Domain.Models;
using MyLovelyDogs.Infrastructure.ExternalServices;

namespace MyLovelyDogs.Application.Services;

public class DogService : IDogService
{
    private readonly TheDogApiClient _dogApiClient;

    public DogService(TheDogApiClient dogApiClient)
    {
        _dogApiClient = dogApiClient;
    }

    public async Task<Image?> GetDogImageByIdAsync(int imageId)
    {
        return await _dogApiClient.GetDogImageByIdAsync(imageId);
    }

    public async Task<List<Breed>?> GetDogInfoByNameAsync(string dogName)
    {
        return await _dogApiClient.GetDogInfoByNameAsync(dogName);
    }
    
}