using SF_25.BLL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public abstract class AbstractBooksView : AbstractView
    {
        public BooksServices booksServices;

        public AbstractBooksView(BooksServices booksServices)
        {
            this.booksServices = booksServices;
        }
        public override void Exit()
        {
            Console.WriteLine("\nНАЖМИТЕ ЛЮБУЮ КЛАВИШУ.");
            Console.ReadKey();
            Console.Clear();
            Program.booksViewMenu.Show();
        }
    }
}
