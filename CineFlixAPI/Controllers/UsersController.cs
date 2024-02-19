using Business.Abstract;

using Entities;

using Microsoft.AspNetCore.Mvc;

namespace CineFlixAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("GetUserById")]
    public IActionResult GetUserById(int userId)
    {
        var result = _userService.GetUserById(userId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("RegisterUser")]
    public IActionResult RegisterUser(User user)
    {
        var result = _userService.RegisterUser(user);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("LoginUser")]
    public IActionResult LoginUser(string username, string password)
    {
        var result = _userService.LoginUser(username, password);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("UpdateUser")]
    public IActionResult UpdateUser(User user)
    {
        var result = _userService.UpdateUser(user);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("DeleteUser")]
    public IActionResult DeleteUser(User user)
    {
        var result = _userService.DeleteUser(user);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

}
