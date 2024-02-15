using Core.DataAccess.EntityFramework;

using DataAccess.Abstract;

using Entities;

namespace DataAccess.Concrete;

public class EfGenreDal : EfEntityRepositoryBase<Genre, CineFlixContext>, IGenreDal
{
}
