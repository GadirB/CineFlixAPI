using Core.Entities;

namespace Entities;

public partial class Movie : IEntity
{
    public int MovieId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public int? GenreId { get; set; }

    //public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    //public virtual Genre? Genre { get; set; }

    //public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();
}
