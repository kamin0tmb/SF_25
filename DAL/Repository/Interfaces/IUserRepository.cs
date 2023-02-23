using SF_25.DAL.Entitys;
using System.Collections.Generic;

namespace SF_25.DAL.Interfaces.Repository
{
    public interface IUserRepository
    {
        void AddNewUser(UserEntity user);
        List<UserEntity> GetAllUsers();
        bool EditUserName(int id, string name);
    }
}