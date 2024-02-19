using Business.Abstract;

using Core.Utilities.Results;

using DataAccess.Abstract;
using DataAccess.Concrete;

using Entities;

namespace Business.Concrete;

public class RatingManager : IRatingService
{
    IRatingDal _ratingDal;

    public RatingManager(IRatingDal ratingDal)
    {
        _ratingDal = ratingDal;
    }

    public IResult AddRating(Rating rating)
    {
        try
        {
            _ratingDal.Add(rating);
            return new SuccessResult("Rating Added Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IResult DeleteRating(Rating rating)
    {
        try
        {
            _ratingDal.Delete(rating);
            return new SuccessResult("Rating Deleted Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IDataResult<Rating> GetAverageRatingByMovieId(int movieId)
    {
        return new SuccessDataResult<Rating>(_ratingDal.Get(r => r.MovieId == movieId));
    }

    public IDataResult<List<Rating>> GetRatingByUserIdAndMovieId(int userId, int movieId)
    {
        return new SuccessDataResult<List<Rating>>(_ratingDal.GetAll(r => r.UserId == userId  && r.MovieId == movieId));
    }

    public IResult UpdateRating(Rating rating)
    {
        try
        {
            _ratingDal.Update(rating);
            return new SuccessResult("Rating Updated Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }
}
