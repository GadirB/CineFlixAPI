using Core.Utilities.Results;

using Entities;

namespace Business.Abstract;

public interface IMovieService
{
    IDataResult<List<Movie>> GetAllMovies();
    IDataResult<Movie> GetMovieById(int movieId);
    IDataResult<List<Movie>> GetMovieByGenre(int genreId);
    IResult AddMovie(Movie movie);
    IResult UpdateMovie(Movie movie);
    IResult DeleteMovie(Movie movie);
}
