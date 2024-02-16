using Core.Utilities.Results;

using Entities;

namespace Business.Abstract;

public interface ICommentService
{
    IResult AddComment(Comment comment);
    IDataResult<List<Comment>> GetCommentsByMovieId(int movieId);
    IDataResult<List<Comment>> GetCommentsByUserID(int userId);
    IResult DeleteComment(Comment comment);
}
