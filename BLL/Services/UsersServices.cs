using Microsoft.EntityFrameworkCore;
using SF_25.BLL.Exeption;
using SF_25.BLL.Models;
using SF_25.DAL.Entitys;
using SF_25.DAL.Interfaces.Repository;
using SF_25.DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SF_25.BLL.Services
{
    public class UsersServices
    {
        IUserRepository userRepository;

        public UsersServices()
        {
            userRepository = new UserRepository();
        }

        public List<UserModel> GetAllUsers()
        {
            var listUsers = userRepository.GetAllUsers();

            var AllUsers = new List<UserModel>();

            foreach (var user in listUsers)
            {
                AllUsers.Add(new UserModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Phone = user.Phone,
                    Email = user.Email
                });
            }

            return AllUsers;
        }

        public void EmailValid(string email)
        {
            if (!new EmailAddressAttribute().IsValid(email))
                throw new EmailValidException();
        }

        public void AddNewUser(UserModel user)
        {
            if (string.IsNullOrEmpty(user.FirstName))
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(user.LastName))
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(user.Phone))
                throw new ArgumentNullException();

            var newUser = new UserEntity()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Email = user.Email
            };

            try
            {
                userRepository.AddNewUser(newUser);
            }
            catch (DbUpdateException)
            {
                throw new FailedToAddException();
            }
        }

        public bool EditUserName(int id, string name)
        {
            return userRepository.EditUserName(id, name);
        }
    }
}
