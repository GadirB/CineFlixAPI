using Business.Abstract;

using Entities.Concrete;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineFlixAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenresController : ControllerBase
{
    IGenreService _genreService;

    public GenresController(IGenreService genreService)
    {
        _genreService = genreService;
    }

    [HttpGet("GetAllGenres")]
    public IActionResult GetAllGenres()
    {
        var result = _genreService.GetAllGenres();
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("GetGenreById")]
    public IActionResult GetGenreById(int genreId)
    {
        var result = _genreService.GetGenreById(genreId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("AddGenre")]
    public IActionResult AddGenre(Genre genre)
    {
        var result = _genreService.AddGenre(genre);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("UpdateGenre")]
    public IActionResult UpdateGenre(Genre genre)
    {
        var result = _genreService.UpdateGenre(genre);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("DeleteGenre")]
    public IActionResult DeleteGenre(Genre genre)
    {
        var result = _genreService.DeleteGenre(genre);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
