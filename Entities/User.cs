using Core.Entities;

namespace Entities;

public partial class User : IEntity
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    //public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    //public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();
}
