using Core.Utilities.Results;

using Entities.Concrete;

namespace Business.Abstract;

public interface IRatingService
{
    IResult AddRating(Rating rating);
    IDataResult<Rating> GetAverageRatingByMovieId(int movieId);
    IDataResult<List<Rating>> GetRatingByUserIdAndMovieId(int userId, int movieId);
    IResult UpdateRating(Rating rating);
    IResult DeleteRating(Rating rating);
}
