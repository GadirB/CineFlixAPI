using Business.Abstract;

using Entities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineFlixAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    IMovieService _movieService;

    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet("GetAllMovies")]
    public IActionResult GetAllMovies()
    {
        var result = _movieService.GetAllMovies();
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("GetMovieById")]
    public IActionResult GetMovieById(int movieId)
    {
        var result = _movieService.GetMovieById(movieId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("GetMovieByGenre")]
    public IActionResult GetMovieByGenre(int genreId)
    {
        var result = _movieService.GetMovieByGenre(genreId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("AddMovie")]
    public IActionResult AddMovie(Movie movie)
    {
        var result = _movieService.AddMovie(movie);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("UpdateMovie")]
    public IActionResult UpdateMovie(Movie movie)
    {
        var result = _movieService.UpdateMovie(movie);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("DeleteMovie")]
    public IActionResult DeleteMovie(Movie movie)
    {
        var result = _movieService.DeleteMovie(movie);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
