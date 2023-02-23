using System;
using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;

namespace SF_25.PLL.Views
{
    public class BooksViewMenu : AbstractBooksView
    {
        public BooksViewMenu(BooksServices booksServices) : base(booksServices) { }

        bool flagCheckCommand = true;

        public override void Show()
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("|                                  МЕНЮ КНИГИ                                    |");
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("   1. Список книг определенного жанра и вышедших между определенными годами.");
                Console.WriteLine("   2. Количество книг определенного автора в библиотеке.");
                Console.WriteLine("   3. Количество книг определенного жанра в библиотеке.");
                Console.WriteLine("   4. Сведения о наличии книги по названию и автору.");
                Console.WriteLine("   5. Сведения о наличии книги на руках у пользователя.");
                Console.WriteLine("   6. Количество книг на руках у пользователя.");
                Console.WriteLine("   7. Список книг последнего года выпуска.");
                Console.WriteLine("   8. Список всех книг, отсортированный в алфавитном порядке по названию.");
                Console.WriteLine("   9. Список всех книг, отсортированный в порядке убывания года их выхода.");
                Console.WriteLine("  10. Добавить книгу.");
                Console.WriteLine("  11. Изменить дату выпуска книги по ID.");
                Console.WriteLine("  12. Удалить книгу.");
                Console.WriteLine("  13. Добавить автора.");
                Console.WriteLine("  14. Добавить издательство.");
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
                                Program.booksView_1.Show();
                                Program.booksView_1.Exit();

                                break;
                            }
                        case 2:
                            {
                                Program.booksView_2.Show();
                                Program.booksView_2.Exit();

                                break;
                            }

                        case 3:
                            {
                                Program.booksView_3.Show();
                                Program.booksView_3.Exit();

                                break;
                            }
                        case 4:
                            {                                
                                Program.booksView_4.Show();
                                Program.booksView_4.Exit();

                                break;
                            }
                        case 5:
                            {
                                Program.booksView_5.Show();
                                Program.booksView_5.Exit();

                                break;
                            }
                        case 6:
                            {
                                Program.booksView_6.Show();
                                Program.booksView_6.Exit();

                                break;
                            }
                        case 7:
                            {
                                Console.Clear();

                                Console.WriteLine("Список книг последнего года выпуска.");

                                Program.booksViewTable.Show(booksServices.LastPublishedBooks());

                                break;
                            }
                        case 8:
                            {
                                Console.Clear();

                                Console.WriteLine("Список книг в алфавитном порядке по названию.");

                                Program.booksViewTable.Show(booksServices.GetBooksSortedTitle());

                                break;
                            }
                        case 9:
                            {
                                Console.Clear();

                                Console.WriteLine("Список книг в порядке убывания года их выхода.");

                                Program.booksViewTable.Show(booksServices.GetBooksSortedYearPublDesc());

                                break;
                            }
                        case 10: 
                            {
                                Program.booksView_10.Show();
                                Program.booksView_10.Exit();

                                break;
                            }
                        case 11: 
                            {
                                Program.booksView_11.Show();
                                Program.booksView_11.Exit();
                                break; 
                            }
                        case 12: 
                            {
                                Program.booksView_12.Show();
                                Program.booksView_12.Exit();
                                break;
                            }
                        case 13: 
                            {
                                Program.booksView_13.Show();
                                Program.booksView_13.Exit();
                                break; 
                            }
                        case 14:
                            {
                                Program.booksView_14.Show();
                                Program.booksView_14.Exit();
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
