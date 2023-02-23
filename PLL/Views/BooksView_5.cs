using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BooksView_5 : AbstractBooksView
    {
        public BooksView_5(BooksServices booksServices) : base(booksServices) { }

        public override void Show()
        {
            Console.Clear();

            Console.Write("Введите название книги: ");
            string title = Console.ReadLine();

            if (!booksServices.СheckBook(title))
            {
                AlertMessage.Show("\nУказанная книга в библиотеке отсутствует.");
            }
            else
            {
                if (booksServices.СheckBookInOrder(title))
                {
                    var userName = booksServices.GetNameUserOrderedTheBook(title);
                    SuccessMessage.Show($"\nЭта книга на руках у абонента:  {userName}");
                }
                else
                {
                    SuccessMessage.Show("\nДанная книга доступна к выдаче.");
                }
            }
        }
    }
}
