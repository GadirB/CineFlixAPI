using Core.Entities;

namespace Entities.Concrete;

public partial class Rating : IEntity
{
    public int RatingId { get; set; }

    public int? MovieId { get; set; }

    public int? UserId { get; set; }

    public decimal? RatingValue { get; set; }

    //public virtual Movie? Movie { get; set; }

    //public virtual User? User { get; set; }
}
