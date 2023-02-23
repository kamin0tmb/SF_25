using SF_25.DAL.Entitys;
using SF_25.DAL.QueryEntitys;
using System.Collections.Generic;

namespace SF_25.DAL.Interfaces.Repository
{
    public interface IBookRepository
    {
        void AddNewAuthor(AuthorEntity author);
        void AddNewBook(BookEntity book);
        void AddNewGenre(GenreEntity genre);
        void AddNewPublishing_house(Publishing_houseEntity publishing_house);
        void DeleteBook(string title);
        List<AuthorEntity> GetAllAuthors();
        List<GenreEntity> GetAllGenres();
        List<Publishing_houseEntity> GetAllPublishing_houses();
        List<BookQueryEntity> GetBooksGenreBetweenYears(string genre_, int year_1, int year_2);
        List<BookQueryEntity> GetAllBooks();
        bool СheckGenre(string genre);
        int NumberBooksTheAuthor(string fullName);
        int NumberBooksTheGenre(string name);
        bool СheckAuthorAndTitleBook(string autorFullName, string titleBook);
        bool СheckBookInOrder(string titleBook);
        string GetNameUserOrderedTheBook(string titleBook);
        bool СheckBook(string title);
        int NumberBooksTheUserHas(string firstName, string lastName);
        bool CheckUser(string firstName, string lastName);
        List<BookQueryEntity> LastPublishedBooks();
        bool СheckAuthor(string fullName);
        int GetIdAuthor(string name);
        int GetIdGenre(string name);
        int GetIdPublishing_house(string name);
        BookQueryEntity GetBook(string title);
        BookEntity GetBookEntity(string title);
        bool EditBookYearPubl(int id, int year);
    }
}