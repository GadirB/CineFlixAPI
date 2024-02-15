using Core.Utilities.Results;

using Entities;

namespace Business.Abstract;

public interface IGenreService
{
    IDataResult<List<Genre>> GetAllGenres();
    IDataResult<Genre> GetGenreById(int genreId);
    IDataResult<Genre> AddGenre();
    IDataResult<Genre> UpdateGenre();
    IDataResult<Genre> DeleteGenre();
}
