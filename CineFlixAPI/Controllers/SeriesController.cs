using Business.Abstract;

using Entities.Concrete;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineFlixAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class SeriesController : ControllerBase
{
    ISeriesService _seriesService;
    public SeriesController(ISeriesService seriesService)
    {
        _seriesService = seriesService;
    }

    [HttpGet("GetAllSeries")]
    public IActionResult GetAllSeries()
    {
        var result = _seriesService.GetAllSeries();
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("GetSeriesById")]
    public IActionResult GetSeriesById(int seriesId)
    {
        var result = _seriesService.GetSeriesById(seriesId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("GetSeriesByGenre")]
    public IActionResult GetSeriesByGenre(int genreId)
    {
        var result = _seriesService.GetSeriesByGenre(genreId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("AddSeries")]
    public IActionResult AddSeries(Series series)
    {
        var result = _seriesService.AddSeries(series);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("UpdateSeries")]
    public IActionResult UpdateSeries(Series series)
    {
        var result = _seriesService.UpdateSeries(series);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("DeleteSeries")]
    public IActionResult DeleteSeries(Series series)
    {
        var result = _seriesService.DeleteSeries(series);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
