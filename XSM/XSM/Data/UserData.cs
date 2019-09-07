using System.Collections.Generic;
using XSM.Models;

namespace XSM.Data
{
    public static class UserData
    {
        public static List<UserEntity> Users()
        {
            return new List<UserEntity>
            {
                new UserEntity
                {
                    Name = "Elena",
                    User = "beelzenef",
                    Password = "demo"
                }
            };
        }
    }
}
