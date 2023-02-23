using SF_25.BLL.Exeption;
using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BooksView_1 : AbstractBooksView
    {
        public BooksView_1(BooksServices booksServices) : base(booksServices) { }

        public override void Show()
        {
            Console.Clear();

            Console.Write("Введите жанр: ");

            string genre = Console.ReadLine();

            int year_1, year_2;

            while (true)
            {
                Console.Write("Введите год от: ");

                if (int.TryParse(Console.ReadLine(), out year_1) && year_1.ToString().Length == 4)
                    break;
                else
                    AlertMessage.Show("Неверный ввод. Вводите год по образцу: 2022");
            }

            while (true)
            {
                Console.Write("Введите год до: ");

                if (int.TryParse(Console.ReadLine(), out year_2) && year_2.ToString().Length == 4)
                    break;
                else
                    AlertMessage.Show("Неверный ввод. Вводите год по образцу: 2022");
            }

            try
            {
                Console.Clear();
                SuccessMessage.Show($"Выбран жанр: {genre}. Годы выпуска: от {year_1} до {year_2}.");
                Program.booksViewTable.Show(booksServices.GetBooksGenreBetweenYears(genre, year_1, year_2));
            }
            catch (BetweenYearsException)
            {
                AlertMessage.Show("\"Год от\" не может быть больше, чем год \"до\"");
            }
        }
    }
}
