using Core.DataAccess.EntityFramework;

using DataAccess.Abstract;

using Entities;

namespace DataAccess.Concrete;

public class EfSeriesDal : EfEntityRepositoryBase<Series, CineFlixContext>, ISeriesDal
{
}
