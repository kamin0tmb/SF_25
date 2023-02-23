using Microsoft.EntityFrameworkCore;
using SF_25.DAL.Entitys;
using System.Linq;

namespace SF_25.DAL.DataForDB_
{ 
    public class BooksData
    {
        public BookEntity Book1 = new BookEntity { AuthorId = 1, GenreId = 1, Publishing_houseId = 1, Title = "1984", Year_of_publication = 2021 };
        public BookEntity Book2 = new BookEntity { AuthorId = 3, GenreId = 1, Publishing_houseId = 4, Title = "Люди как боги", Year_of_publication = 1995, };
        public BookEntity Book3 = new BookEntity { AuthorId = 6, GenreId = 1, Publishing_houseId = 3, Title = "Час Быка", Year_of_publication = 2008 };
        public BookEntity Book4 = new BookEntity { AuthorId = 6, GenreId = 1, Publishing_houseId = 5, Title = "Туманность Андромеды", Year_of_publication = 1985 };
        public BookEntity Book5 = new BookEntity { AuthorId = 6, GenreId = 4, Publishing_houseId = 1, Title = "Таис Афинская", Year_of_publication = 2017 };
        public BookEntity Book6 = new BookEntity { AuthorId = 2, GenreId = 1, Publishing_houseId = 1, Title = "Академия", Year_of_publication = 2019 };
        public BookEntity Book7 = new BookEntity { AuthorId = 2, GenreId = 1, Publishing_houseId = 1, Title = "Академия и империя", Year_of_publication = 2019 };
        public BookEntity Book8 = new BookEntity { AuthorId = 2, GenreId = 1, Publishing_houseId = 2, Title = "Основание и Земля", Year_of_publication = 2017 };
        public BookEntity Book9 = new BookEntity { AuthorId = 2, GenreId = 1, Publishing_houseId = 1, Title = "Я, робот", Year_of_publication = 2019 };
        public BookEntity Book10 = new BookEntity { AuthorId = 4, GenreId = 1, Publishing_houseId = 1, Title = "Космическая одиссея", Year_of_publication = 2018 };
        public BookEntity Book11 = new BookEntity { AuthorId = 4, GenreId = 1, Publishing_houseId = 4, Title = "Город и звёзды", Year_of_publication = 2018 };
        public BookEntity Book12 = new BookEntity { AuthorId = 5, GenreId = 1, Publishing_houseId = 6, Title = "Пикник на обочине", Year_of_publication = 2021 };
        public BookEntity Book13 = new BookEntity { AuthorId = 5, GenreId = 1, Publishing_houseId = 3, Title = "Трудно быть богом", Year_of_publication = 2019 };
        public BookEntity Book14 = new BookEntity { AuthorId = 5, GenreId = 1, Publishing_houseId = 5, Title = "Понедельник начинается в субботу", Year_of_publication = 2019 };
        public BookEntity Book15 = new BookEntity { AuthorId = 5, GenreId = 1, Publishing_houseId = 4, Title = "Улитка на склоне", Year_of_publication = 2021 };
        public BookEntity Book16 = new BookEntity { AuthorId = 5, GenreId = 1, Publishing_houseId = 3, Title = "Обитаемый остров", Year_of_publication = 1999 };
        public BookEntity Book17 = new BookEntity { AuthorId = 5, GenreId = 1, Publishing_houseId = 4, Title = "Жук в муравейнике", Year_of_publication = 2009 };
        public BookEntity Book18 = new BookEntity { AuthorId = 7, GenreId = 2, Publishing_houseId = 1, Title = "Приключения Шерлока Холмса", Year_of_publication = 2019 };
        public BookEntity Book19 = new BookEntity { AuthorId = 8, GenreId = 2, Publishing_houseId = 6, Title = "Приключения Тома Сойера", Year_of_publication = 1998 };
        public BookEntity Book20 = new BookEntity { AuthorId = 9, GenreId = 2, Publishing_houseId = 6, Title = "Дети капитана Гранта", Year_of_publication = 1988 };
        public BookEntity Book21 = new BookEntity { AuthorId = 9, GenreId = 2, Publishing_houseId = 2, Title = "Двадцать тысяч лье под водой", Year_of_publication = 2001 };
        public BookEntity Book22 = new BookEntity { AuthorId = 9, GenreId = 2, Publishing_houseId = 3, Title = "Таинственный остров", Year_of_publication = 2020 };
        public BookEntity Book23 = new BookEntity { AuthorId = 9, GenreId = 2, Publishing_houseId = 4, Title = "Вокруг света за восемьдесят дней", Year_of_publication = 2017 };
        public BookEntity Book24 = new BookEntity { AuthorId = 10, GenreId = 3, Publishing_houseId = 2, Title = "Парус одинокий (ностальгический детектив)", Year_of_publication = 2015 };
        public BookEntity Book25 = new BookEntity { AuthorId = 11, GenreId = 3, Publishing_houseId = 3, Title = "Поэты и убийцы", Year_of_publication = 2018 };

        public void Record(AppContext db)
        {
            db.Books.AddRange(Book1, Book2, Book3, Book4, Book5, Book6, Book7, Book8, Book9, Book10,
                              Book11, Book12, Book13, Book14, Book15, Book16, Book17, Book18, Book19, Book20,
                              Book21, Book22, Book23, Book24, Book25);

            db.SaveChanges();
        }
    }
}
