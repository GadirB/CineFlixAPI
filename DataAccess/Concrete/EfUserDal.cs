using Core.DataAccess.EntityFramework;

using DataAccess.Abstract;

using Entities;

namespace DataAccess.Concrete;

public class EfUserDal : EfEntityRepositoryBase<User, CineFlixContext>, IUserDal
{
}
