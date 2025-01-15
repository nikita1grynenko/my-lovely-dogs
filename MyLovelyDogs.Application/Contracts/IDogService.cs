using MyLovelyDogs.Domain.Models;

namespace MyLovelyDogs.Application.Contracts;

public interface IDogService
{
    Task<Image?> GetDogImageByIdAsync(int imageId);
    Task<List<Breed>?> GetDogInfoByNameAsync(string dogName);
}