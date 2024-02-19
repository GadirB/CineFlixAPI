using Core.Utilities.Results;

using Entities;

namespace Business.Abstract;

public interface ICommentService
{
    IResult AddComment(Comment comment);
    IDataResult<List<Comment>> GetCommentsByMovieId(int movieId);
    IDataResult<List<Comment>> GetCommentsByUserId(int userId);
    IResult UpdateComment(Comment comment);
    IResult DeleteComment(Comment comment);
}
