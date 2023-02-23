using SF_25.BLL.Models;
using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BooksView_13 : AbstractBooksView
    {
        public BooksView_13(BooksServices booksServices) : base(booksServices) { }

        public override void Show()
        {
            Console.Clear();

            Console.WriteLine("\tВВОД НОВОГО АВТОРА.\n");

            var author = new AuthorModel();

            Console.Write("Введите полное имя автора: ");

            author.Full_name = Console.ReadLine();

            if (booksServices.AddNewAuthor(author))
            {
                SuccessMessage.Show("Автор успешно  добавлен.\n");

                var listAuthor = booksServices.GetAllAuthors().OrderBy(a => a.Full_name);

                int numPP = 1;

                foreach (var author_ in listAuthor)
                {
                    Console.WriteLine(numPP + ". " + author_.Full_name);

                    numPP++;
                }
            }
            else
                AlertMessage.Show("Автор с таким именем уже существует.");
        }
    }
}
