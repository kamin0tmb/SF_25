using System;

namespace SF_25.PLL.Views
{
    public class RootMenuView
    {
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("|                                ГЛАВНОЕ МЕНЮ                                    |");
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("                        1. Перейти в меню \"КНИГИ\".");
                Console.WriteLine("                        2. Перейти в меню \"АБОНЕНТЫ\".");
                Console.WriteLine("                        3. Перейти в меню \"ЗАКАЗЫ\".");
                Console.WriteLine("                        4. Создать базу данных.");
                Console.WriteLine("\nВВЕДИТЕ ЦИФРУ ПУНКТА МЕНЮ ИЛИ НАЖМИТЕ \"END\" ДЛЯ ВЫХОДА ИЗ ПРОГРАММЫ.");

                string command = KeyReader.KeyRead();
                
                if (command.Contains("End"))
                    Environment.Exit(0);

                if (int.TryParse(command, out int result))
                {
                    switch (result)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Program.booksViewMenu.Show();
                                
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                Program.usersViewMenu.Show();

                                break;
                            }

                        case 3:
                            {
                                Console.Clear();
                                Program.ordersViewMenu.Show();

                                break;
                            }
                        case 4:
                            {
                                try
                                {
                                    CreateDB.Run();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                                Console.Clear();

                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
            }
        }
    }
}
