using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BooksView_4 : AbstractBooksView
    {
        public BooksView_4(BooksServices booksServices) : base(booksServices) { }

        public override void Show()
        {
            Console.Clear();

            Console.Write("Введите полное имя автора: ");
            string fullName = Console.ReadLine();

            Console.Write("Введите название книги: ");
            string title = Console.ReadLine();

            if (booksServices.СheckAuthorAndTitleBook(fullName, title))
                SuccessMessage.Show("\nЕсть такая книга.");
            else
                AlertMessage.Show("\nНет такой книги.");
        }
    }
}
