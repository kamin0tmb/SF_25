using SF_25.BLL.Services;
using SF_25.DAL.Repository;
using SF_25.PLL;
using SF_25.PLL.Views;
using System;

namespace SF_25
{
    class Program
    {
        static BooksServices booksServices;
        static UsersServices usersServices;

        public static RootMenuView rootMenuView;

        public static BooksViewMenu booksViewMenu;
        public static BooksViewTable booksViewTable;
        public static BooksView_1 booksView_1;
        public static BooksView_2 booksView_2;
        public static BooksView_3 booksView_3;
        public static BooksView_4 booksView_4;
        public static BooksView_5 booksView_5;
        public static BooksView_6 booksView_6;
        public static BooksView_10 booksView_10;
        public static BooksView_11 booksView_11;
        public static BooksView_12 booksView_12;
        public static BooksView_13 booksView_13;
        public static BooksView_14 booksView_14;

        public static UsersViewMenu usersViewMenu;
        public static UsersViewTable usersViewTable;
        public static UsersView_2 usersView_2;
        public static UsersView_3 usersView_3;

        public static OrdersViewMenu ordersViewMenu;

        static void Main(string[] args)
        {
            Console.SetWindowSize(140, 40);

            booksServices = new BooksServices();
            usersServices = new UsersServices();

            rootMenuView = new RootMenuView();

            booksViewMenu = new BooksViewMenu(booksServices);
            booksViewTable = new BooksViewTable();
            booksView_1 = new BooksView_1(booksServices);
            booksView_2 = new BooksView_2(booksServices);
            booksView_3 = new BooksView_3(booksServices);
            booksView_4 = new BooksView_4(booksServices);
            booksView_5 = new BooksView_5(booksServices);
            booksView_6 = new BooksView_6(booksServices);
            booksView_10 = new BooksView_10(booksServices);
            booksView_11 = new BooksView_11(booksServices);
            booksView_12 = new BooksView_12(booksServices);
            booksView_13 = new BooksView_13(booksServices);
            booksView_14 = new BooksView_14(booksServices);

            usersViewMenu = new UsersViewMenu(usersServices);
            usersViewTable= new UsersViewTable();
            usersView_2 = new UsersView_2(usersServices);
            usersView_3 = new UsersView_3(usersServices);

            ordersViewMenu = new OrdersViewMenu();

            rootMenuView.Show();
        }
    }
}
