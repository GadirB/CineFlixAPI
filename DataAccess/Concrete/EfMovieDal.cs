using Core.DataAccess.EntityFramework;

using DataAccess.Abstract;

using Entities;

namespace DataAccess.Concrete;

public class EfMovieDal : EfEntityRepositoryBase<Movie, CineFlixContext>, IMovieDal
{
}
