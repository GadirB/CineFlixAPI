using Business.Abstract;

using Core.Entities.Concrete;

using Entities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineFlixAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class CommentsController : ControllerBase
{
    ICommentService _commentService;

    public CommentsController(ICommentService commentService)
    {
        _commentService = commentService;
    }

    [HttpGet("GetCommentsByMovieId")]
    public IActionResult GetCommentsByMovieId(int movieId)
    {
        var result = _commentService.GetCommentsByMovieId(movieId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("GetCommentsByUserId")]
    public IActionResult GetCommentsByUserId(int userId)
    {
        var result = _commentService.GetCommentsByUserId(userId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("AddComment")]
    public IActionResult AddComment(Comment comment)
    {
        var result = _commentService.AddComment(comment);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("UpdateComment")]
    public IActionResult UpdateComment(Comment comment)
    {
        var result = _commentService.UpdateComment(comment);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("DeleteComment")]
    public IActionResult DeleteComment(Comment comment)
    {
        var result = _commentService.DeleteComment(comment);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
