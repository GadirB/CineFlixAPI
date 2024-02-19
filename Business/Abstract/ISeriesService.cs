using Core.Utilities.Results;

using Entities.Concrete;

namespace Business.Abstract;

public interface ISeriesService
{
    IDataResult<List<Series>> GetAllSeries();
    IDataResult<Series> GetSeriesById(int seriesId);
    IDataResult<List<Series>> GetSeriesByGenre(int genreId);
    IResult AddSeries(Series series);
    IResult UpdateSeries(Series series);
    IResult DeleteSeries(Series series);

}
