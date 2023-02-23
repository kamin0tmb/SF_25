using SF_25.BLL.Models;
using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BooksView_12 : AbstractBooksView
    {
        public BooksView_12(BooksServices booksServices) : base(booksServices) { }

        public override void Show()
        {
            Console.Clear();

            Console.WriteLine("\tУДАЛЕНИЕ КНИГИ.\n");

            Console.Write("Введите название книги: ");
            
            string title = Console.ReadLine();

            if(booksServices.СheckBook(title))
            {
                booksServices.DeleteBook(title);
                SuccessMessage.Show("Книга удалена.");
            }
            else
            {
                AlertMessage.Show("Книга с таким названием отсутствует.");
            }

            Console.WriteLine();
        }
    }
}
