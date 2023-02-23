using SF_25.BLL.Services;
using System;
using System.Collections.Generic;
using SF_25.PLL.Views.Helpers;

namespace SF_25.PLL.Views
{
    public class BooksView_2 : AbstractBooksView
    {
        public BooksView_2(BooksServices booksServices) : base(booksServices) { }

        public override void Show()
        {
            Console.Clear();

            Console.Write("Введите полное имя автора: ");
            string fullName = Console.ReadLine();

            if (booksServices.СheckAuthor(fullName))
            {
                SuccessMessage.Show($"\nКоличество наименований книг автора {fullName} составляет: " +
                                    $"{booksServices.NumberBooksTheAuthor(fullName)}.");
            }
            else
            {
                AlertMessage.Show("Автор не обнаружен.");
            }
        }
    }
}
