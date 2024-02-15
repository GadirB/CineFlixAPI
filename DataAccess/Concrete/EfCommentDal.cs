using Core.DataAccess.EntityFramework;

using DataAccess.Abstract;

using Entities;

namespace DataAccess.Concrete;

public class EfCommentDal : EfEntityRepositoryBase<Comment, CineFlixContext>, ICommentDal
{
}
