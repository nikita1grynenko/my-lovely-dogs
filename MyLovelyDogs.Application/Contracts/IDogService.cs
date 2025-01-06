using MyLovelyDogs.Domain.Models;

namespace MyLovelyDogs.Application.Contracts;

public interface IDogService
{
    Task<Image?> GetDogImageByIdAsync(string imageId);
}