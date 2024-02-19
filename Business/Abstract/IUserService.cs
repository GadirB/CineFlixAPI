using Core.Utilities.Results;

using Entities;

namespace Business.Abstract;

public interface IUserService
{
    IResult RegisterUser(User user);
    IResult LoginUser(string username, string password);
    IDataResult<User> GetUserById(int userId);
    IResult UpdateUser(User user);
    IResult DeleteUser(User user);
}
