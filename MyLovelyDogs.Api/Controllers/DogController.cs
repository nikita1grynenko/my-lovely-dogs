using Microsoft.AspNetCore.Mvc;
using MyLovelyDogs.Application.Contracts;

namespace MyLovelyDogs.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DogController : ControllerBase
{
    private readonly IDogService _catService;

    public DogController(IDogService catService)
    {
        _catService = catService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetImageById(string id)
    {
        var image = await _catService.GetDogImageByIdAsync(id);
        if (image == null)
            return NotFound();

        return Ok(image);
    }
}