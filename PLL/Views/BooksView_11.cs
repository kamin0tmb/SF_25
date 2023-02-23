using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BooksView_11 : AbstractBooksView
    {
        public BooksView_11(BooksServices booksServices) : base(booksServices) { }

        public override void Show()
        {
            Console.Clear();

            Console.WriteLine("\tИЗМЕНЕНИЕ ГОДА ВЫПУСКА КНИГИ.\n");
                        
            int id;

            while (true)
            {
                Console.Write("Введите ID книги: ");

                try
                {
                    id = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    AlertMessage.Show("Вводите число.");
                }
            }

            Console.Write("Введите год для обновления: ");

            int year = int.Parse(Console.ReadLine());

            if (booksServices.EditBookYearPubl(id, year))
                SuccessMessage.Show("Обновление прошло успешно.\n");
            else
                AlertMessage.Show("Книги с таким ID не существует.");
        }
    }
}
