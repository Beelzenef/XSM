using System.Collections.Generic;
using XSM.Data;
using XSM.Models;

namespace XSM.Services.Users
{
    public class UserService : IUserService
    {
        public IList<UserEntity> GetAllUsers()
        {
            return UserData.Users();
        }

        public bool CheckUserData(string username, string password)
        {
            return UserData.Users()
                .Exists(u => u.User == username && u.Password == password);
        }
    }
}
