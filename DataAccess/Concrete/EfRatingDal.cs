using Core.DataAccess.EntityFramework;

using DataAccess.Abstract;

using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfRatingDal : EfEntityRepositoryBase<Rating, CineFlixContext>, IRatingDal
{
}
