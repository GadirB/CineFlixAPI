using Core.Utilities.Results;

using Entities;

namespace Business.Abstract;

public interface ISeriesService
{
    IDataResult<List<Series>> GetAllSeries();
    IDataResult<Series> GetSeriesById(int seriesId);
    IDataResult<Series> GetSeriesByGenre(int genreId);
    IDataResult<Series> AddSeries();
    IDataResult<Series> UpdateSeries();
    IDataResult<Series> DeleteSeries();

}
