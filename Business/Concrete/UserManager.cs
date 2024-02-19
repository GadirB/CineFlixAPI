using Business.Abstract;

using Core.Utilities.Results;

using DataAccess.Abstract;
using DataAccess.Concrete;

using Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class UserManager : IUserService
{
    IUserDal _userDal;

    public UserManager(IUserDal userDal)
    {
        _userDal = userDal;
    }

    public IResult DeleteUser(User user)
    {
        try
        {
            _userDal.Delete(user);
            return new SuccessResult("User Deleted Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IDataResult<User> GetUserById(int userId)
    {
        return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == userId));
    }

    public IResult LoginUser(string username, string password)
    {
        var existingUser = _userDal.Get(u => u.Username == username && u.Password == password);

        if (existingUser != null)
        {
            return new SuccessResult("Login Successful");
        }
        else
        {
            return new ErrorResult("Invalid username or password");
        }
    }

    public IResult RegisterUser(User user)
    {
        try
        {
            _userDal.Add(user);
            return new SuccessResult("User Registered Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }

    public IResult UpdateUser(User user)
    {
        try
        {
            _userDal.Update(user);
            return new SuccessResult("User Updated Succesfully");
        }
        catch (Exception ex)
        {

            return new ErrorResult("Error: " + ex.Message);
        }
    }
}
