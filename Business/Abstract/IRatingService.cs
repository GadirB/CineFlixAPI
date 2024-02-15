using Core.Utilities.Results;

using Entities;

namespace Business.Abstract;

public interface IRatingService
{
    IDataResult<Rating> AddRating();
    IDataResult<Rating> GetAverageRatingByMovieId(int movieId);
    IDataResult<Rating> GetRatingByUserIdAndMovieId(int userId, int movieId);
    IDataResult<Rating> UpdateRating();
    IDataResult<Rating> DeleteRating();
}
