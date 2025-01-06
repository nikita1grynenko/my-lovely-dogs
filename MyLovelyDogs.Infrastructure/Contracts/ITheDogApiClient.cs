using MyLovelyDogs.Domain.Models;

namespace MyLovelyDogs.Infrastructure.Contracts;

public interface ITheDogApiClient
{
    Task<Image?> GetDogImageByIdAsync(string imageId);
}