using SF_25.BLL.Exeption;
using SF_25.BLL.Models;
using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BooksView_10 : AbstractBooksView
    {
        public BooksView_10(BooksServices booksServices) : base(booksServices) { }

        public override void Show()
        {
            var book = new BookModelAdd();

            Console.Clear();

            Console.WriteLine("\tВВОД НОВОЙ КНИГИ.\n");

            //-------------------------------------------------
            Console.Write("Введите название книги: ");

            book.Title = Console.ReadLine();

            Console.WriteLine();

            //-------------------------------------------------
            Console.WriteLine("Выберите автора из списка.\n");

            var listAuthor = booksServices.GetAllAuthors().OrderBy(a => a.Full_name);

            var tempList = new List<TempEntity>();

            int numPP = 1;

            foreach (var author in listAuthor)
            {
                Console.WriteLine(numPP + ". " + author.Full_name);

                tempList.Add(new TempEntity() { NumPP = numPP, Name = author.Full_name });

                numPP++;
            }

            book.Author = SelectFromList(tempList);


            //-------------------------------------------------
            Console.WriteLine();

            Console.WriteLine("Выберите жанр.\n");

            var listGenres = booksServices.GetAllGenres().OrderBy(g => g.Name);

            tempList = new List<TempEntity>();

            numPP = 1;

            foreach (var genre in listGenres)
            {
                Console.WriteLine(numPP + ". " + genre.Name);

                tempList.Add(new TempEntity() { NumPP = numPP, Name = genre.Name });

                numPP++;
            }

            book.Genre = SelectFromList(tempList);


            //-------------------------------------------------
            Console.WriteLine();

            int Year_of_publication = 0;

            while (true)
            {
                Console.Write("Введите год публикации книги: ");
                
                if (int.TryParse(Console.ReadLine(), out Year_of_publication) && Year_of_publication.ToString().Length == 4)
                    break;
                else
                    AlertMessage.Show("Неверный ввод. Вводите год по образцу: 2022");
            }

            book.Year_of_publication = Year_of_publication;


            //-------------------------------------------------
            Console.WriteLine();

            Console.WriteLine("Выберите издательство.\n");

            var listPH = booksServices.GetAllPublishing_houses().OrderBy(h => h.Name);

            numPP = 1;

            tempList = new List<TempEntity>();

            foreach (var PH in listPH)
            {
                Console.WriteLine(numPP + ". " + PH.Name);

                tempList.Add(new TempEntity() { NumPP = numPP, Name = PH.Name });

                numPP++;
            }            

            book.Publishing_house = SelectFromList(tempList);

            Console.WriteLine();


            //-------------------------------------------------
            try
            {
                booksServices.AddNewBook(book);

                SuccessMessage.Show("Книга успешно дабавлена.\n");

                var bookList = new List<BookModel>();

                bookList.Add(booksServices.GetBook(book.Title));

                Program.booksViewTable.Show(bookList);
            }
            catch(FailedToAddException)
            {
                Console.WriteLine("При добавлении книги произошла непредвиденная ошибка. Попробуйте снова.");
            }
        }

        private string SelectFromList(List<TempEntity> tempEntity)
        {
            Console.Write("Введите номер из списка: ");

            string name = null;

            while (true)
            {
                int num = 0;
                
                if (int.TryParse(Console.ReadLine(), out int inNum))
                {
                    foreach (var entity in tempEntity)
                    {
                        if (entity.NumPP == inNum)
                        {
                            num = entity.NumPP;
                            name = entity.Name;
                        }
                    }
                    if (num > 0)
                    {
                        break;
                    }
                    else
                        AlertMessage.Show("Вводите число только из списка: ");
                }
            }

            return name;
        }
    }
}
