using SF_25.DAL.Entitys;

namespace SF_25.DAL.DataForDB_
{
    public class GenresData
    {
        public GenreEntity Genre1 = new GenreEntity { Name = "Фантастика" };
        public GenreEntity Genre2 = new GenreEntity { Name = "Приключения" };
        public GenreEntity Genre3 = new GenreEntity { Name = "Детектив" };
        public GenreEntity Genre4 = new GenreEntity { Name = "Исторический роман" };

        public void Record(AppContext db)
        {
            //db.Genres.AddRange(Genre1, Genre2, Genre3, Genre4);
            //db.SaveChanges();
            db.Genres.Add(Genre1);
            db.SaveChanges();

            db.Genres.Add(Genre2);
            db.SaveChanges();

            db.Genres.Add(Genre3);
            db.SaveChanges();

            db.Genres.Add(Genre4);
            db.SaveChanges();
        }
    }
}
