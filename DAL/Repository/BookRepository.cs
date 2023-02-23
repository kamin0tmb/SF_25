using SF_25.BLL.Exeption;
using SF_25.DAL.Entitys;
using SF_25.DAL.Interfaces.Repository;
using SF_25.DAL.QueryEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.DAL.Repository
{
    public class BookRepository : IBookRepository
    {
        public List<BookQueryEntity> GetAllBooks()
        {
            var AllBooks = new List<BookQueryEntity>();

            using (var db = new AppContext())
            {
                var booksQuery = (from book in db.Books
                                  join author in db.Authors on book.AuthorId equals author.Id
                                  join genre in db.Genres on book.GenreId equals genre.Id
                                  join p in db.Publishing_houses on book.Publishing_houseId equals p.Id
                                  select new BookQueryEntity
                                  {
                                      Title = book.Title,
                                      Author = author.Full_name,
                                      Genre = genre.Name,
                                      Publishing_house = p.Name,
                                      Year_of_publication = book.Year_of_publication.ToString()
                                  }).ToList();

                foreach (var book in booksQuery)
                {
                    AllBooks.Add(book);
                }
            }
            return AllBooks;
        }


        public List<GenreEntity> GetAllGenres()
        {
            using (var db = new AppContext())
            {
                return db.Genres.ToList();
            }
        }

        public List<AuthorEntity> GetAllAuthors()
        {
            using (var db = new AppContext())
            {
                return db.Authors.ToList();
            }
        }

        public List<Publishing_houseEntity> GetAllPublishing_houses()
        {
            using (var db = new AppContext())
            {
                return db.Publishing_houses.ToList();
            }
        }

        public void AddNewBook(BookEntity book)
        {
            using (var db = new AppContext())
            {
                db.Books.Add(book);

                db.SaveChanges();
            }
        }

        public void AddNewAuthor(AuthorEntity author)
        {
            using (var db = new AppContext())
            {
                db.Authors.Add(author);

                db.SaveChanges();
            }
        }

        public void AddNewGenre(GenreEntity genre)
        {
            using (var db = new AppContext())
            {
                db.Genres.Add(genre);

                db.SaveChanges();
            }
        }

        public void AddNewPublishing_house(Publishing_houseEntity publishing_house)
        {
            using (var db = new AppContext())
            {
                db.Publishing_houses.Add(publishing_house);

                db.SaveChanges();
            }
        }

        public void DeleteBook(string title)
        {
            using (var db = new AppContext())
            {
                var book = GetBookEntity(title);

                db.Books.Remove(book);

                db.SaveChanges();
            }
        }

        public List<BookQueryEntity> GetBooksGenreBetweenYears(string genre_, int year_1, int year_2)
        {
            if (!СheckGenre(genre_))
                throw new ArgumentException();

            if (!(year_1 < year_2))
                throw new BetweenYearsException();

            var Books = new List<BookQueryEntity>();

            using (var db = new AppContext())
            {
                var booksQuery = (from book in db.Books
                                  join author in db.Authors on book.AuthorId equals author.Id
                                  join genre in db.Genres on book.GenreId equals genre.Id
                                  join p in db.Publishing_houses on book.Publishing_houseId equals p.Id
                                  where genre.Name == genre_
                                  where book.Year_of_publication >= year_1
                                  where book.Year_of_publication <= year_2
                                  select new BookQueryEntity
                                  {
                                      Title = book.Title,
                                      Author = author.Full_name,
                                      Genre = genre.Name,
                                      Publishing_house = p.Name,
                                      Year_of_publication = book.Year_of_publication.ToString()
                                  })
                                  .OrderBy(b => b.Year_of_publication)
                                  .ToList();

                foreach (var book in booksQuery)
                {
                    Books.Add(book);
                }
            }
            return Books;
        }

        public bool СheckGenre(string genre)
        {
            List<GenreEntity> genres = GetAllGenres();

            foreach (var gen in genres)
            {
                if (gen.Name == genre)
                    return true;
            }

            return false;
        }

        public bool СheckBook(string title)
        {
            bool result;

            using (var db = new AppContext())
            {
                result = db.Books.Where(b => b.Title == title).Any();
            }

            return result;
        }

        public int NumberBooksTheAuthor(string fullName)
        {
            int result = 0;

            using (var db = new AppContext())
            {
                result = (from book in db.Books
                          join author in db.Authors on book.AuthorId equals author.Id
                          where author.Full_name == fullName
                          select book)
                          .Count();
            }

            return result;
        }

        public int NumberBooksTheGenre(string name)
        {
            int result = 0;

            using (var db = new AppContext())
            {
                result = (from book in db.Books
                          join genre in db.Genres on book.GenreId equals genre.Id
                          where genre.Name == name
                          select book)
                          .Count();
            }

            return result;
        }

        public bool СheckAuthorAndTitleBook(string autorFullName, string titleBook)
        {
            bool result;

            using (var db = new AppContext())
            {
                result = db.Books.Join(db.Authors,
                        b => b.AuthorId,
                        a => a.Id,
                        (b, a) => new
                        {
                            book = b.Title,
                            author = a.Full_name
                        }
                        )
                        .Where(b => b.book == titleBook && b.author == autorFullName)
                        .Any();

            }

            return result;
        }

        public bool СheckAuthor(string fullName)
        {
            bool result;

            using (var db = new AppContext())
            {
                result = db.Authors.Where(a => a.Full_name == fullName).Any();
            }

            return result;
        }

        public bool СheckBookInOrder(string titleBook)
        {
            bool result;

            using (var db = new AppContext())
            {
                result = db.Books.Join(db.Orders,
                        b => b.Id,
                        o => o.BookId,
                        (b, o) => new
                        {
                            b.Title,
                            o.Flag_return
                        }
                        )
                        .Where(b => b.Title == titleBook && b.Flag_return == false)
                        .Any();
            }

            return result;
        }

        public string GetNameUserOrderedTheBook(string titleBook)
        {
            string userName = "";

            using (var db = new AppContext())
            {
                var result = db.Books.Join(db.Orders,
                            b => b.Id,
                            o => o.BookId,
                            (b, o) => new
                            {
                                b.Title,
                                o.UserId,
                                o.Flag_return
                            }).Join(db.Users,
                            n => n.UserId,
                            u => u.Id,
                            (n, u) => new
                            {
                                n.Title,
                                u.FirstName,
                                u.LastName,
                                n.Flag_return
                            })
                            .Where(b => b.Title == titleBook && b.Flag_return == false)
                            .First();

                userName = result.FirstName + " " + result.LastName;
            }

            return userName;
        }

        public int NumberBooksTheUserHas(string firstName, string lastName)
        {
            int number = 0;

            using (var db = new AppContext())
            {
                number = (from order in db.Orders
                          join user in db.Users on order.UserId equals user.Id
                          where user.FirstName == firstName && user.LastName == lastName && order.Flag_return == false
                          select order)
                          .Count();
            }

            return number;
        }

        public bool CheckUser(string firstName, string lastName)
        {
            bool result;

            using (var db = new AppContext())
            {
                result = db.Users.Where(u => u.FirstName == firstName && u.LastName == lastName).Any();
            }

            return result;
        }

        public List<BookQueryEntity> LastPublishedBooks()
        {
            var books = new List<BookQueryEntity>();

            using (var db = new AppContext())
            {
                var maxYear = db.Books.Max(b => b.Year_of_publication);

                var bookQuery = (from book in db.Books
                                 join author in db.Authors on book.AuthorId equals author.Id
                                 join genre in db.Genres on book.GenreId equals genre.Id
                                 join p in db.Publishing_houses on book.Publishing_houseId equals p.Id
                                 select new
                                 {
                                     book.Title,
                                     Author = author.Full_name,
                                     Genre = genre.Name,
                                     Publishing_house = p.Name,
                                     book.Year_of_publication
                                 })
                                .Where(x => x.Year_of_publication == maxYear);

                foreach (var book in bookQuery)
                {
                    books.Add(new BookQueryEntity()
                    {
                        Title = book.Title,
                        Author = book.Author,
                        Genre = book.Genre,
                        Publishing_house = book.Publishing_house,
                        Year_of_publication = book.Year_of_publication.ToString()
                    });
                }
            }

            return books;
        }

        public int GetIdAuthor(string name)
        {
            int id;

            using (var db = new AppContext())
            {
                id = db.Authors.Where(a => a.Full_name == name).Select(a => a.Id).First();
            }

            return id;
        }

        public int GetIdGenre(string name)
        {
            int id;

            using (var db = new AppContext())
            {
                id = (db.Genres.Where(g => g.Name == name).Select(g => g.Id)).First();
            }

            return id;
        }


        public int GetIdPublishing_house(string name)
        {
            int id;

            using (var db = new AppContext())
            {
                id = db.Publishing_houses.Where(ph => ph.Name == name).Select(ph => ph.Id).First();
            }

            return id;
        }

        public BookQueryEntity GetBook(string title)
        {
            var Book = new BookQueryEntity();

            using (var db = new AppContext())
            {
                Book = (from book in db.Books
                        join author in db.Authors on book.AuthorId equals author.Id
                        join genre in db.Genres on book.GenreId equals genre.Id
                        join p in db.Publishing_houses on book.Publishing_houseId equals p.Id
                        where book.Title == title
                        select new BookQueryEntity
                        {
                            Title = book.Title,
                            Author = author.Full_name,
                            Genre = genre.Name,
                            Publishing_house = p.Name,
                            Year_of_publication = book.Year_of_publication.ToString()
                        }).First();
            }
            return Book;
        }

        public BookEntity GetBookEntity(string title)
        {
            using (var db = new AppContext())
            {
                return db.Books.Where(b => b.Title == title).First();
            }                            
        }

        public bool EditBookYearPubl(int id, int year)
        {
            bool result = false;

            using (var db = new AppContext())
            {
                var book = db.Books.Where(b => b.Id == id).FirstOrDefault();

                if(book != null)
                {
                    book.Year_of_publication = year;
                    db.SaveChanges();
                    result = true;
                }
            }

            return result;
        }
    }
}
