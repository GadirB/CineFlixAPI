using Core.Entities;

namespace Entities.Concrete;

public partial class Series : IEntity
{
    public int SeriesId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateOnly? ReleaseDate { get; set; }

    public int? GenreId { get; set; }

    //public virtual Genre? Genre { get; set; }
}
