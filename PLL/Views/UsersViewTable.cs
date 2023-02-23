using System.Collections.Generic;
using SF_25.DAL.Entitys;
using System;
using SF_25.BLL.Services;
using SF_25.BLL.Models;

namespace SF_25.PLL.Views
{
    public class UsersViewTable
    {
        public void Show(List<UserModel> users)
        {
            int numberPP = 1;

            Console.WriteLine("\t\tСПИСОК АБОНЕНТОВ");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("|№п/п|          ФИО           |     Телефон      |      Почта      |");
            Console.WriteLine("--------------------------------------------------------------------");

            foreach (var user in users)
            {
                Console.WriteLine("| {0, -2} | {1, -10} {2, -12}| {3, -12} | {4, -16}|", 
                                  numberPP, user.FirstName, user.LastName, user.Phone, user.Email);
                numberPP++;
            }

            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("\nДЛЯ ВЫХОДА НАЖМИТЕ ЛЮБУЮ КЛАВИШУ.");
            Console.ReadKey();
            Console.Clear();
            Program.usersViewMenu.Show();
        }
    }
}
