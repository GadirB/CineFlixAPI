using Core.Entities;

namespace Entities.DTOs;

public class UserForLoginDto : IDto
{
    public string Name { get; set; }
    public string Password { get; set; }
}
