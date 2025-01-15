using Microsoft.AspNetCore.Mvc;
using MyLovelyDogs.Application.Contracts;

namespace MyLovelyDogs.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DogController : ControllerBase
{
    private readonly IDogService _dogService;

    public DogController(IDogService dogService)
    {
        _dogService = dogService;
    }

    [HttpGet("image/{id}")]
    public async Task<IActionResult> GetImageById(int id)
    {
        var image = await _dogService.GetDogImageByIdAsync(id);
        if (image == null)
            return NotFound();

        return Ok(image);
    }
    
    [HttpGet("name/{name}")]
    public async Task<IActionResult> GetInfoByName(string name)
    {
        var info = await _dogService.GetDogInfoByNameAsync(name);
        if (info == null)
            return NotFound();

        return Ok(info);
    }
}