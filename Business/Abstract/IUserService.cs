using Core.Utilities.Results;

using Entities;

namespace Business.Abstract;

public interface IUserService
{
    IDataResult<User> RegisterUser();
    IDataResult<User> LoginUser();
    IDataResult<User> GetUserById(int userId);
    IDataResult<User> UpdateUser();
    IDataResult<User> DeleteUser();
}
