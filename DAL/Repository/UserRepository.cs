using SF_25.DAL.Entitys;
using SF_25.DAL.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
         public List<UserEntity> GetAllUsers()
        {
            using (var db = new AppContext())
            {
                return db.Users.OrderBy(u => u.LastName).ToList();
            }
        }

        public void AddNewUser(UserEntity user)
        {
            using (var db = new AppContext())
            {
                db.Users.Add(user);

                db.SaveChanges();
            }
        }

        public bool EditUserName(int id, string name)
        {
            bool result = false;

            using (var db = new AppContext())
            {
                var user = db.Users.Where(u => u.Id == id).FirstOrDefault();

                if (user != null)
                {
                    user.FirstName = name;
                    db.SaveChanges();
                    result = true;
                }
            }

            return result;
        }
    }
}
