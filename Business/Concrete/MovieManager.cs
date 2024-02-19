using Business.Abstract;

using Core.Entities.Concrete;
using Core.Utilities.Results;

using DataAccess.Abstract;
using DataAccess.Concrete;

using Entities;

namespace Business.Concrete;

public class MovieManager : IMovieService
{
    IMovieDal _movieDal;

    public MovieManager(IMovieDal movieDal)
    {
        _movieDal = movieDal;
    }

    public IResult AddMovie(Movie movie)
    {
        try
        {
            _movieDal.Add(movie);
            return new SuccessResult("Movie Added Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IResult DeleteMovie(Movie movie)
    {
        try
        {
            _movieDal.Delete(movie);
            return new SuccessResult("Movie Deleted Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IDataResult<List<Movie>> GetAllMovies()
    {
        return new SuccessDataResult<List<Movie>>(_movieDal.GetAll());
    }

    public IDataResult<List<Movie>> GetMovieByGenre(int genreId)
    {
        return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(m => m.GenreId == genreId));
    }

    public IDataResult<Movie> GetMovieById(int movieId)
    {
        return new SuccessDataResult<Movie>(_movieDal.Get(m => m.MovieId == movieId));
    }

    public IResult UpdateMovie(Movie movie)
    {
        try
        {
            _movieDal.Update(movie);
            return new SuccessResult("Movie Updated Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }
}
