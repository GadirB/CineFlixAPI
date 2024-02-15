using Core.Entities;

namespace Entities;

public partial class Series : IEntity
{
    public int SeriesId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public int? GenreId { get; set; }

    public virtual Genre? Genre { get; set; }
}
