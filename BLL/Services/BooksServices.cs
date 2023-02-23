using Microsoft.EntityFrameworkCore;
using SF_25.BLL.Exeption;
using SF_25.BLL.Models;
using SF_25.DAL.Entitys;
using SF_25.DAL.Interfaces.Repository;
using SF_25.DAL.QueryEntitys;
using SF_25.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.BLL.Services
{
    public class BooksServices
    {
        IBookRepository bookRepository;

        public BooksServices()
        {
            bookRepository = new BookRepository();
        }

        public List<BookModel> GetBooksSortedTitle()
        {
            return ConstructListBook(GetAllBooks().OrderBy(b => b.Title));
        }

        public List<BookModel> GetBooksSortedYearPublDesc()
        {
            return ConstructListBook(GetAllBooks().OrderByDescending(b => b.Year_of_publication));
        }

        private List<BookModel> ConstructListBook(IOrderedEnumerable<BookModel> temp)
        {
            var listBooks = new List<BookModel>();

            foreach (var book in temp)
            {
                listBooks.Add(book);
            }

            return listBooks;
        }

        private List<BookModel> GetAllBooks()
        {
            var query = bookRepository.GetAllBooks();

            var listBooks = new List<BookModel>();

            foreach (var book in query)
            {
                listBooks.Add(new BookModel
                {
                    Author = book.Author,
                    Genre = book.Genre,
                    Publishing_house = book.Publishing_house,
                    Title = book.Title,
                    Year_of_publication = book.Year_of_publication
                });
            }

            return listBooks;
        }

        public List<BookModel> GetBooksGenreBetweenYears(string genre_, int year_1, int year_2)
        {
            if (year_1 > year_2)
                throw new BetweenYearsException();

            var query = bookRepository.GetBooksGenreBetweenYears(genre_, year_1, year_2);

            var listBooks = new List<BookModel>();

            foreach (var book in query)
            {
                listBooks.Add(new BookModel
                {
                    Author = book.Author,
                    Genre = book.Genre,
                    Publishing_house = book.Publishing_house,
                    Title = book.Title,
                    Year_of_publication = book.Year_of_publication
                });
            }

            return listBooks;
        }

        public int NumberBooksTheAuthor(string fullName)
        {
            return bookRepository.NumberBooksTheAuthor(fullName);
        }

        public int NumberBooksTheGenre(string name)
        {
            return bookRepository.NumberBooksTheGenre(name);
        }

        public bool СheckAuthorAndTitleBook(string autorFullName, string titleBook)
        {
            return bookRepository.СheckAuthorAndTitleBook(autorFullName, titleBook);
        }

        public bool СheckBookInOrder(string titleBook)
        {
            return bookRepository.СheckBookInOrder(titleBook);
        }

        public string GetNameUserOrderedTheBook(string titleBook)
        {
            return bookRepository.GetNameUserOrderedTheBook(titleBook);
        }

        public bool СheckBook(string title)
        {
            return bookRepository.СheckBook(title);
        }

        public int NumberBooksTheUserHas(string firstName, string lastName)
        {
            return bookRepository.NumberBooksTheUserHas(firstName, lastName);
        }

        public bool CheckUser(string firstName, string lastName)
        {
            return bookRepository.CheckUser(firstName, lastName);
        }

        public List<BookModel> LastPublishedBooks()
        {
            var listBookQueryEntity = bookRepository.LastPublishedBooks();

            var listBooks = new List<BookModel>();

            foreach (var book in listBookQueryEntity)
            {
                listBooks.Add(new BookModel
                {
                    Author = book.Author,
                    Genre = book.Genre,
                    Publishing_house = book.Publishing_house,
                    Title = book.Title,
                    Year_of_publication = book.Year_of_publication
                });
            }

            return listBooks;
        }

        public bool СheckAuthor(string fullName)
        {
            return bookRepository.СheckAuthor(fullName);
        }

        public List<AuthorModel> GetAllAuthors()
        {
            var list = bookRepository.GetAllAuthors();

            var listAuthors = new List<AuthorModel>();

            foreach (var author in list)
            {
                listAuthors.Add(new AuthorModel() { Full_name = author.Full_name });
            }

            return listAuthors;
        }

        public List<GenresModel> GetAllGenres()
        {
            var list = bookRepository.GetAllGenres();

            var listGenres = new List<GenresModel>();

            foreach (var genre in list)
            {
                listGenres.Add(new GenresModel() { Name = genre.Name });
            }

            return listGenres;
        }

        public List<Publishing_housesModel> GetAllPublishing_houses()
        {
            var list = bookRepository.GetAllPublishing_houses();

            var listPH = new List<Publishing_housesModel>();

            foreach (var PH in list)
            {
                listPH.Add(new Publishing_housesModel() { Name = PH.Name });
            }

            return listPH;
        }

        public void AddNewBook(BookModelAdd book)
        {
            var book_ = new BookEntity();

            book_.Title = book.Title;
            book_.AuthorId = bookRepository.GetIdAuthor(book.Author);
            book_.GenreId = bookRepository.GetIdGenre(book.Genre);
            book_.Year_of_publication = book.Year_of_publication;
            book_.Publishing_houseId = bookRepository.GetIdPublishing_house(book.Publishing_house);

            try
            {
                bookRepository.AddNewBook(book_);
            }
            catch (DbUpdateException)
            {
                throw new FailedToAddException();
            }
        }

        public BookModel GetBook(string title)
        {
            var book = bookRepository.GetBook(title);

            return new BookModel()
            {
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                Year_of_publication = book.Year_of_publication,
                Publishing_house = book.Publishing_house
            };
        }

        public bool AddNewAuthor(AuthorModel author)
        {
            if (!bookRepository.СheckAuthor(author.Full_name))
            {
                bookRepository.AddNewAuthor(new AuthorEntity() { Full_name = author.Full_name });

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddNewGenre(GenresModel genre)
        {
            if (!bookRepository.СheckGenre(genre.Name))
            {
                bookRepository.AddNewGenre(new GenreEntity() { Name = genre.Name });

                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteBook(string title)
        {
            bookRepository.DeleteBook(title);
        }

        public bool EditBookYearPubl(int id, int year)
        {
            return bookRepository.EditBookYearPubl(id, year);
        }
    }
}
