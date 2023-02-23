using SF_25.BLL.Models;
using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BooksView_14 : AbstractBooksView
    {
        public BooksView_14(BooksServices booksServices) : base(booksServices) { }

        public override void Show()
        {
            Console.Clear();

            Console.WriteLine("\tВВОД НОВОГО ИЗДАТЕЛЬСТВА.\n");

            var genre = new GenresModel();

            Console.Write("Введите название: ");

            genre.Name = Console.ReadLine();

            if (booksServices.AddNewGenre(genre))
            {
                SuccessMessage.Show("Издательство успешно  добавлено.\n");

                var listGenre = booksServices.GetAllGenres().OrderBy(g => g.Name);

                int numPP = 1;

                foreach (var genre_ in listGenre)
                {
                    Console.WriteLine(numPP + ". " + genre_.Name);

                    numPP++;
                }
            }
            else
                AlertMessage.Show("Издательство с таким названием уже существует.");
        }
    }
}
