using Business.Abstract;

using Core.Utilities.Results;

using DataAccess.Abstract;

using Entities;

namespace Business.Concrete;

public class CommentManager : ICommentService
{
    ICommentDal _commentDal;

    public CommentManager(ICommentDal commentDal)
    {
        _commentDal = commentDal;
    }

    public IResult AddComment(Comment comment)
    {
        try
        {
            _commentDal.Add(comment);
            return new SuccessResult("Comment Added Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IResult DeleteComment(Comment comment)
    {
        try
        {
            _commentDal.Delete(comment);
            return new SuccessResult("Comment Deleted Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IDataResult<List<Comment>> GetCommentsByMovieId(int movieId)
    {
        return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(c => c.MovieId == movieId));
    }

    public IDataResult<List<Comment>> GetCommentsByUserID(int userId)
    {
        return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(c => c.UserId == userId));
    }
}
