using SF_25.BLL.Exeption;
using SF_25.BLL.Models;
using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class UsersView_2 : AbstractUsersView
    {
        public UsersView_2(UsersServices userServices) : base(userServices) { }

        public override void Show()
        {
            var user = new UserModel();

            Console.Clear();

            Console.WriteLine("\tВВОД ДАННЫХ НОВОГО АБОНЕНТА.\n");
            
            Console.Write("Введите имя: ");

            user.FirstName = Console.ReadLine();

            Console.Write("Введите фамилию: ");

            user.LastName = Console.ReadLine();

            Console.Write("Введите номер телефона: ");

            user.Phone = Console.ReadLine();
            
            string email; 

            while (true)
            {
                try
                {
                    Console.Write("Введите почту: ");

                    email = Console.ReadLine();

                    usersServices.EmailValid(email);

                    break;
                }
                catch (EmailValidException)
                {
                    AlertMessage.Show("Неверный формат почты.");
                }
            }

            user.Email = email;

            try
            {
                usersServices.AddNewUser(user);

                SuccessMessage.Show("Новый абонент успешно добавлен.");
            }
            catch(ArgumentNullException)
            {
                AlertMessage.Show("Все поля должны быть заполнены.");
            }
            catch(FailedToAddException)
            {
                AlertMessage.Show("При добавлении абонента произошла непредвиденная ошибка. Попробуйте снова.");
            }
        }
    }
}
