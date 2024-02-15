using Core.Utilities.Results;

using Entities;

namespace Business.Abstract;

public interface IMovieService
{
    IDataResult<List<Movie>> GetAllMovies();
    IDataResult<Movie> GetMovieById(int movieId);
    IDataResult<Movie> GetMovieByGenre(int genreId);
    IDataResult<Movie> AddMovie();
    IDataResult<Movie> UpdateMovie();
    IDataResult<Movie> DeleteMovie();
}
