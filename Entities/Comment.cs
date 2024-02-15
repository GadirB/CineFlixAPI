using Core.Entities;

namespace Entities;

public partial class Comment: IEntity
{
    public int CommentId { get; set; }

    public int? MovieId { get; set; }

    public int? UserId { get; set; }

    public string? CommentText { get; set; }

    public DateTime? CommentDate { get; set; }

    public virtual Movie? Movie { get; set; }

    public virtual User? User { get; set; }
}
