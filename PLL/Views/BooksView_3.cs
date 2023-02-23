using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BooksView_3 : AbstractBooksView
    {
        public BooksView_3(BooksServices booksServices) : base(booksServices) { }

        public override void Show()
        {
            Console.Clear(); 

            Console.Write("Введите название жанра: ");
            string name = Console.ReadLine();

            SuccessMessage.Show($"\nКоличество наименований книг жанра {name} " +
                                $"составляет: {booksServices.NumberBooksTheGenre(name)}.");
        }
    }
}
