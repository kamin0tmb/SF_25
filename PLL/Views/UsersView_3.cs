using SF_25.BLL.Exeption;
using SF_25.BLL.Models;
using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class UsersView_3 : AbstractUsersView
    {
        public UsersView_3(UsersServices userServices) : base(userServices) { }

        public override void Show()
        {
            Console.Clear();

            Console.WriteLine("\tИЗМЕНЕНИЕ ИМЕНИ АБОНЕНТА.\n");

            int id;

            while (true)
            {
                Console.Write("Введите ID абонента: ");

                try
                {
                    id = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    AlertMessage.Show("Вводите число.");
                }
            }

            Console.Write("Введите новое имя: ");

            string name = Console.ReadLine();

            if (usersServices.EditUserName(id, name))
                SuccessMessage.Show("Обновление прошло успешно.\n");
            else
                AlertMessage.Show("Абонента с таким ID не существует.");
        }
    }
}
