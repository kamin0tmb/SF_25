using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class UsersViewMenu : AbstractUsersView
    {
        public UsersViewMenu(UsersServices usersServices) : base(usersServices) { }

        bool flagCheckCommand = true;

        public override void Show()
        {
            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("|                               МЕНЮ АБОНЕНТЫ                               |");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("   1. Список абонентов.");
                Console.WriteLine("   2. Добавить абонента.");
                Console.WriteLine("   3. Обновление имени пользователя по ID.");
                Console.WriteLine("\nВВЕДИТЕ ЦИФРУ ПУНКТА МЕНЮ ИЛИ НАЖМИТЕ \"END\" ДЛЯ ВЫХОДА В ГЛАНОЕ МЕНЮ.");

                if (!flagCheckCommand)
                {
                    AlertMessage.Show("Незарегистрированная команда");
                    flagCheckCommand = true;
                }

                string command = KeyReader.KeyRead();

                if (command.Contains("End"))
                {
                    Console.Clear();
                    Program.rootMenuView.Show();
                }

                if (int.TryParse(command, out int result))
                {
                    switch (result)
                    {
                        case 1:
                            {                                
                                Console.Clear();

                                Console.WriteLine("Список абонентов.");

                                Program.usersViewTable.Show(usersServices.GetAllUsers());

                                break;
                            }
                        case 2:
                            {
                                Program.usersView_2.Show();
                                Program.usersView_2.Exit();

                                break;
                            }

                        case 3:
                            {
                                Program.usersView_3.Show();
                                Program.usersView_3.Exit();

                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                flagCheckCommand = false;

                                break;
                            }
                    }
                }
                else
                {
                    Console.Clear();
                    flagCheckCommand = false;
                }
            }
        }
    }
}
