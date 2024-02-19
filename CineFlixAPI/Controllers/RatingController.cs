using Business.Abstract;

using Entities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineFlixAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RatingController : ControllerBase
{
    IRatingService _ratingService;

    public RatingController(IRatingService ratingService)
    {
        _ratingService = ratingService;
    }

    [HttpGet("GetAverageRatingByMovieId")]
    public IActionResult GetAverageRatingByMovieId(int movieId)
    {
        var result = _ratingService.GetAverageRatingByMovieId(movieId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("GetRatingByUserIdAndMovieId")]
    public IActionResult GetRatingByUserIdAndMovieId(int userId, int movieId)
    {
        var result = _ratingService.GetRatingByUserIdAndMovieId(userId, movieId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("AddRating")]
    public IActionResult AddRating(Rating rating)
    {
        var result = _ratingService.AddRating(rating);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("UpdateRating")]
    public IActionResult UpdateRating(Rating rating)
    {
        var result = _ratingService.UpdateRating(rating);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("DeleteRating")]
    public IActionResult DeleteRating(Rating rating)
    {
        var result = _ratingService.DeleteRating(rating);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
