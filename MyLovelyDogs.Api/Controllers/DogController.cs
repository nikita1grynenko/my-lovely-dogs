using Microsoft.AspNetCore.Mvc;
using MyLovelyDogs.Application.Contracts;

namespace MyLovelyDogs.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DogController : ControllerBase
{
    private readonly IDogService _dogService;

    public DogController(IDogService dogService)
    {
        _dogService = dogService;
    }

    [HttpGet("imageById/{id}")]
    public async Task<IActionResult> GetImageById(string id)
    {
        var image = await _dogService.GetDogImageByIdAsync(id);
        if (image == null)
            return NotFound();

        return Ok(image);
    }
    
    [HttpGet("infoByName/{name}")]
    public async Task<IActionResult> GetInfoByName(string name)
    {
        var info = await _dogService.GetDogInfoByNameAsync(name);
        if (info == null)
            return NotFound();

        return Ok(info);
    }
}