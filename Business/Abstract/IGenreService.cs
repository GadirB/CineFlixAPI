using Core.Utilities.Results;

using Entities;

namespace Business.Abstract;

public interface IGenreService
{
    IDataResult<List<Genre>> GetAllGenres();
    IDataResult<Genre> GetGenreById(int genreId);
    IResult AddGenre(Genre genre);
    IResult UpdateGenre(Genre genre);
    IResult DeleteGenre(Genre genre);
}
