using Core.Utilities.Results;

using Entities;

namespace Business.Abstract;

public interface ICommentService
{
    IDataResult<Comment> AddComment();
    IDataResult<List<Comment>> GetCommentsByMovieId(int movieId);
    IDataResult<List<Comment>> GetCommentsByUserID(int userId);
    IDataResult<Comment> DeleteComment();
}
