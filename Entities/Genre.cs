using Core.Entities;

namespace Entities;

public partial class Genre : IEntity
{
    public int GenreId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();

    public virtual ICollection<Series> Series { get; set; } = new List<Series>();
}
