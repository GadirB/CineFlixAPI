using Core.DataAccess.EntityFramework;

using DataAccess.Abstract;

using Entities;

namespace DataAccess.Concrete;

public class EfRatingDal : EfEntityRepositoryBase<Rating, CineFlixContext>, IRatingDal
{
}
