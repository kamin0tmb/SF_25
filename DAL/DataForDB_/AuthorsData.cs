using SF_25.DAL.Entitys;
using System;

namespace SF_25.DAL.DataForDB_
{
    public class AuthorsData
    {
        public AuthorEntity Author1 = new AuthorEntity { Full_name = "Джордж Оруэлл" };
        public AuthorEntity Author2 = new AuthorEntity { Full_name = "Айзек Азимов" };
        public AuthorEntity Author3 = new AuthorEntity { Full_name = "Сергей Снегов" };
        public AuthorEntity Author4 = new AuthorEntity { Full_name = "Артур Кларк" };
        public AuthorEntity Author5 = new AuthorEntity { Full_name = "Аркадий и Борис Стругацкие" };
        public AuthorEntity Author6 = new AuthorEntity { Full_name = "Иван Антонович Ефремов" };
        public AuthorEntity Author7 = new AuthorEntity { Full_name = "Артур Конан Дойл" };
        public AuthorEntity Author8 = new AuthorEntity { Full_name = "Марк Твен" };
        public AuthorEntity Author9 = new AuthorEntity { Full_name = "Жюль Верн" };
        public AuthorEntity Author10 = new AuthorEntity { Full_name = "Борис Акунин" };
        public AuthorEntity Author11 = new AuthorEntity { Full_name = "Роберт ван Гулик" };

        public void Record(AppContext db)
        {            
            db.Authors.AddRange(Author1, Author2, Author3, Author4, Author5, Author6, Author7,
                                Author8, Author9, Author10, Author11);
            db.SaveChanges();
        }
    }
}
