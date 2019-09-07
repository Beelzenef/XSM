using System.Collections.Generic;
using XSM.Models;

namespace XSM.Services.Users
{
    public interface IUserService
    {
        IList<UserEntity> GetAllUsers();
        bool CheckUserData(string username, string password);
    }
}
