using Business.Abstract;

using Core.Utilities.Results;

using DataAccess.Abstract;
using DataAccess.Concrete;

using Entities.Concrete;

namespace Business.Concrete;

public class SeriesManager : ISeriesService
{
    ISeriesDal _seriesDal;

    public SeriesManager(ISeriesDal seriesDal)
    {
        _seriesDal = seriesDal;
    }

    public IResult AddSeries(Series series)
    {
        try
        {
            _seriesDal.Add(series);
            return new SuccessResult("Series Added Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IResult DeleteSeries(Series series)
    {
        try
        {
            _seriesDal.Delete(series);
            return new SuccessResult("Series Deleted Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IDataResult<List<Series>> GetAllSeries()
    {
        return new SuccessDataResult<List<Series>>(_seriesDal.GetAll());
    }

    public IDataResult<List<Series>> GetSeriesByGenre(int genreId)
    {
        return new SuccessDataResult<List<Series>>(_seriesDal.GetAll(s => s.GenreId == genreId));
    }

    public IDataResult<Series> GetSeriesById(int seriesId)
    {
        return new SuccessDataResult<Series>(_seriesDal.Get(s => s.SeriesId == seriesId));
    }

    public IResult UpdateSeries(Series series)
    {
        try
        {
            _seriesDal.Update(series);
            return new SuccessResult("Series Updated Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }
}
