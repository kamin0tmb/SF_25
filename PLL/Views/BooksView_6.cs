using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BooksView_6 : AbstractBooksView
    {
        public BooksView_6(BooksServices booksServices) : base(booksServices) { }

        public override void Show()
        {
            Console.Clear();

            Console.Write("Введите имя абонента: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите фамилию абонента: ");
            string lastName = Console.ReadLine();

            if (booksServices.CheckUser(firstName, lastName))
            {
                var number = booksServices.NumberBooksTheUserHas(firstName, lastName);

                SuccessMessage.Show($"\nКоличество книг на руках у абонента {firstName} {lastName} равно {number}.");
            }
            else
            {
                AlertMessage.Show("\nПользователь не зарегистрирован.");
            }
        }
    }
}
