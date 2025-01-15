using MyLovelyDogs.Domain.Models;

namespace MyLovelyDogs.Application.Contracts;

public interface IDogService
{
    Task<Image?> GetDogImageByIdAsync(string imageId);
    Task<List<Breed>?> GetDogInfoByNameAsync(string dogName);
}