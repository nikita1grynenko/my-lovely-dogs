using MyLovelyDogs.Domain.Models;

namespace MyLovelyDogs.Infrastructure.Contracts;

public interface ITheDogApiClient
{
    Task<Image?> GetDogImageByIdAsync(int imageId);
    Task<List<Breed>?> GetDogInfoByNameAsync(string dogName);
}