using System.Collections.Generic;
using System;
using SF_25.BLL.Models;
using SF_25.BLL.Services;

namespace SF_25.PLL.Views
{
    public class BooksViewTable
    {        
        public void Show(List<BookModel> books)
        {
            int numberPP = 1;

            Console.WriteLine("\n                                                  СПИСОК КНИГ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|№п/п|                   Название                |             Автор          |        Жанр        |    Изд-во   |Год |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            foreach (var book in books)
            {
                Console.WriteLine("| {0, -2} | {1, -41} | {2, -26} | {3, -18} | {4, -11} |{5, -4}|",
                                  numberPP, book.Title, book.Author, book.Genre, book.Publishing_house, book.Year_of_publication);

                numberPP++;
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            Console.Write("\nДЛЯ ВЫХОДА НАЖМИТЕ ЛЮБУЮ КЛАВИШУ.");
            Console.ReadKey();
            Console.Clear();
            Program.booksViewMenu.Show();
        }
    }
}
