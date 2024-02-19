using Business.Abstract;
using Business.Constants;

using Core.Utilities.Results;

using DataAccess.Abstract;

using Entities.Concrete;

namespace Business.Concrete;

public class GenreManager : IGenreService
{
    IGenreDal _genreDal;

    public GenreManager(IGenreDal genreDal)
    {
        _genreDal = genreDal;
    }

    public IResult AddGenre(Genre genre)
    {
        try
        {
            _genreDal.Add(genre);
            return new SuccessResult("Genre Added Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IResult DeleteGenre(Genre genre)
    {
        try
        {
            _genreDal.Delete(genre);
            return new SuccessResult("Genre Deleted Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IDataResult<List<Genre>> GetAllGenres()
    {
        return new SuccessDataResult<List<Genre>>(_genreDal.GetAll());
    }

    public IDataResult<Genre> GetGenreById(int genreId)
    {
        return new SuccessDataResult<Genre>(_genreDal.Get(g => g.GenreId == genreId));
    }

    public IResult UpdateGenre(Genre genre)
    {
        try
        {
            _genreDal.Update(genre);
            return new SuccessResult("Genre Updated Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }
}
